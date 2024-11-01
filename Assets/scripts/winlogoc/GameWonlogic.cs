using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWonlogic : MonoBehaviour
{
    public GameObject WinScreen;
    
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()) {

            
           
            LevelManager.Instance.SetStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
            WinScreen.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
