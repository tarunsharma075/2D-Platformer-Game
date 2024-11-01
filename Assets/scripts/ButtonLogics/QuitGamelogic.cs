using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGamelogic : MonoBehaviour
{
   
    public  Button QuitButton;
    
   
    void Start()
    {
        QuitButton.onClick.AddListener(OnClickQuit);
    }

    private void OnClickQuit()
    {
        Debug.Log("YOU QUIT THE GAME");
      Application.Quit();
    }
    
}
