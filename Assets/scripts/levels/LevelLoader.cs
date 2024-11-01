using System;
using System.Collections;
using Unity.Burst;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))] 
public class LevelLoader : MonoBehaviour
    {
    private Button _levelbutton;
    public  string LevelName;

    private void Awake()
    {
        _levelbutton = GetComponent<Button>();
        _levelbutton.onClick.AddListener(OnClick);
    }

    private void OnClick()
        
    {
        LevelStatus  LS= LevelManager.Instance.GetStatus(LevelName);
        switch (LS)
        {

            case LevelStatus.Locked:
                Debug.Log("LOCKED");
                SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
                break;
          case LevelStatus.Unlocked:
                Debug.Log("UNLOCKED");
                SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
                SceneManager.LoadScene(LevelName);
                
                break;
            case LevelStatus.Completed:
                Debug.Log("completed");
                SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
                SceneManager.LoadScene(LevelName);
                break;

        }
        
    }
}
