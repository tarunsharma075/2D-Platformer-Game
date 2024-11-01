using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartLogic : MonoBehaviour


{

    public string LevelToChange;
    public Button _clickedbutton;
    // Start is called before the first frame update

    private void Awake()
    {
        _clickedbutton = gameObject.GetComponent<Button>();

    }
   public void Start()
    {
        _clickedbutton.onClick.AddListener(OnClick);
    }

   public void OnClick()
    {
        SceneManager.LoadScene(LevelToChange);
    }
}
