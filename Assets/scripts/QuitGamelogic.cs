using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGamelogic : MonoBehaviour
{
   
    public  Button quitbutton;
    
   
    void Start()
    {
        quitbutton.onClick.AddListener(onclickquit);
    }

    private void onclickquit()
    {
        Debug.Log("YOU QUIT THE GAME");
      Application.Quit();
    }
    
}
