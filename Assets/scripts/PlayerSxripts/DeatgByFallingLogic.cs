using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeatgByFallingLogic : MonoBehaviour
{
     public GameObject RestartPopup;
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
              
            action();
           
        }
    }

   public void action()
    {
        RestartPopup.SetActive(true);
        Player.SetActive(false);
    }
}
