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
                break;
          case LevelStatus.unlocked:
                Debug.Log("UNLOCKED");
                SceneManager.LoadScene(Level_name);
                break;
            case LevelStatus.completed:
                Debug.Log("completed");
                SceneManager.LoadScene(Level_name);
                break;

        }
        
    }
}
