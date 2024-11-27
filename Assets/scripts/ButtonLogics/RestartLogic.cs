using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartLogic : MonoBehaviour
{
    [SerializeField] private Button _clickedbutton; // Drag the button here in the Inspector
    private Scene _activeScene;
     int  _activeSceneIndex;

    private void Start()
    {
        
        if (_clickedbutton != null)
        {
            _clickedbutton.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("Button reference is not assigned in the Inspector.");
        }

    }

    private void OnClick()
    {
        if (_activeScene != null)
        {
            Debug.Log("button clicked");
            SceneManager.LoadScene(_activeSceneIndex);
        }
        else
        {
            Debug.LogError("Active scene not found.");
        }
    }
}
