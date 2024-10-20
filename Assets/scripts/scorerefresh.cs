using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using System;

public class scorerefresh : MonoBehaviour
{
    private TextMeshProUGUI scoretext;
    private int score=0;

    private void Awake()
    {
        scoretext=GetComponent<TextMeshProUGUI>();

    }
    private void Start()
    {
        Refreshui();
    }

    public void increasescore(int increment)
    {
        score += increment;
        Refreshui();
    }

    private void Refreshui()
    {
        scoretext.text= "Score"+ score;
    }
}
