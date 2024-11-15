using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using System;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class UiForScore : MonoBehaviour
{
    private TextMeshProUGUI _scoretext;
    private int Score = 0;
   

   
 

    private void Awake()
    {
        _scoretext = GetComponent<TextMeshProUGUI>();
       

    }
    public  void Start()
    {
        Refreshui();
    }

    public void IncreaseScore(int increment)
    {
        Score += increment;
        Refreshui();
    }

    private void Refreshui()
    {
        _scoretext.text = "Score" + Score;
        
    }


    

   

   
}



