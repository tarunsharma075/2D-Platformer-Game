using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLogic : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()) {

            Debug.Log("Enter the trigger");
            SoundManager.Instance.Play(SoundManager.sounds.StageClear);
            LevelManager.Instance.MarkLevelComplete();
           
          
        }
    }
   
}
