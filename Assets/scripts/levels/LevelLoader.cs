using System;
using System.Collections;
using Unity.Burst;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))] 
public class LevelLoader : MonoBehaviour
    {
    private Button LevelButton;
    public  string Level_name;

    private void Awake()
    {
        LevelButton = GetComponent<Button>();
        LevelButton.onClick.AddListener(onclick);
    }

    private void onclick()
        
    {
        LevelStatus  LS= LevelManager.Instance.getstatus(Level_name);
        switch (LS)
        {

            case LevelStatus.locked:
                Debug.Log("LOCKED");
                SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
                break;
          case LevelStatus.unlocked:
                Debug.Log("UNLOCKED");
                SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
                SceneManager.LoadScene(Level_name);
                
                break;
            case LevelStatus.completed:
                Debug.Log("completed");
                SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
                SceneManager.LoadScene(Level_name);
                break;

        }
        
    }
}
