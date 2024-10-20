using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMESTARTANDQUITLOGIC : MonoBehaviour
{
    public  Button startbutton;
    
    public string chanagelevel;
   
    void Start()
    {
        startbutton.onClick.AddListener(onclickstart);
    }

    private void onclickstart()
    {
      SceneManager.LoadScene(chanagelevel);
    }
    
}
