using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartLogic : MonoBehaviour


{

    public string LevelToChange;
    private Button ClickedButton;
    // Start is called before the first frame update

    private void Awake()
    {
        ClickedButton = GetComponent<Button>();

    }
    private void Start()
    {
        ClickedButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadScene(LevelToChange);
    }
}
