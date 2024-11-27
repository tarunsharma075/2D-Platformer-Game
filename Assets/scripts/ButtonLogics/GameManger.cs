using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    [SerializeField] private Button _mainMenUbtton;
    [SerializeField] private Button _resumebutton;
    [SerializeField] private GameObject _mainGameScreen;
    [SerializeField] private GameObject _resumeGameScreen;
    [SerializeField] private GameObject _player;

    private void Start()
    {
        _mainMenUbtton.onClick.AddListener(OnClickMainMenuButton);
        _resumebutton.onClick.AddListener(OnClickResumeButton);
    }
    
    private  void OnClickMainMenuButton()
    {
        SceneManager.LoadScene("");
    }
   private  void OnClickResumeButton()
    {
        _resumeGameScreen.SetActive(false);
        _mainGameScreen.SetActive(true);
        _player.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            _mainGameScreen.SetActive(false);
            _resumeGameScreen.SetActive(true);
            _player.SetActive(false);

        }
    }
}
