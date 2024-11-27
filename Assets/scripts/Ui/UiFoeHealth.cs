using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiFoeHealth : MonoBehaviour
{
    public  int _health = 3;
    [SerializeField] private Image[] _hearts;
    [SerializeField] private Sprite _fullheart;
    [SerializeField] private Sprite _emptyheart;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _player;
    private Scene _currentScene;
    private int _currentSceneIndex;

   

    public void Damage()
    {
        _health--;
        RefreshUi();
        
        if (_health <= 0)
        {
          
            StartCoroutine(PopUpAppear());
        }

    }



    

    void RefreshUi()
    {

        foreach (Image img in _hearts)
        {

            img.sprite = _emptyheart;



        }
        for (int i = 0; i < _health; i++)
        {

            _hearts[i].sprite = _fullheart;
        }
    }

    private void Start()
    {
        _currentScene = SceneManager.GetActiveScene();
        _currentSceneIndex = _currentScene.buildIndex;
        RefreshUi();


    }
    private IEnumerator PopUpAppear()
    {
        _animator.SetBool("dead", true);
        yield return new WaitForSeconds(2f);
        _player.SetActive(false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene( _currentSceneIndex );

    }

   



}

