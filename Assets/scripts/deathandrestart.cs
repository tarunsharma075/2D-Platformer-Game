using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathandrestart : MonoBehaviour
{
     public GameObject restartPopup;
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            restartPopup.SetActive(true);
            Player.SetActive(false);
        }
    }
}
