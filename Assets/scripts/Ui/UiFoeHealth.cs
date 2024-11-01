using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiFoeHealth : MonoBehaviour
{
    public  int _health = 3;
    [SerializeField] private Image[] _hearts;
    [SerializeField] private Sprite _fullheart;
    [SerializeField] private Sprite _emptyheart;
    [SerializeField] private Animator _animator;
    [SerializeField] private DeatgByFallingLogic _restartpop;
    [SerializeField] private GameObject Player;


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
        RefreshUi();


    }
    private IEnumerator PopUpAppear()
    {
        _animator.SetBool("dead", true);
        yield return new WaitForSeconds(2f);
        _restartpop.action();


    }

    //private IEnumerator PlayerStop()
    //{
    //    Player.SetActive(false);
    //     yield return new WaitForSeconds(10f);
    //    Player.SetActive(true);
    //}




}

