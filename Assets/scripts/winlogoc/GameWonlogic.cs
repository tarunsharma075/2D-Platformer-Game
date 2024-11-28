using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWonlogic : MonoBehaviour
{
    public GameObject _winGameScreen;
    public GameObject _mainGameScrren;
    public GameObject _player;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()) {



            LevelManager.Instance.MarkLevelComplete();
            SoundManager.Instance.Play(SoundManager.sounds.StageClear);
            StartCoroutine(WiningTheGame());
            
        }
    }

    private IEnumerator WiningTheGame()
    {
         _winGameScreen.SetActive(true);
        _mainGameScrren.SetActive(false);
        _player.SetActive(false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("StartingScene");
    }
}
