using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winlogic : MonoBehaviour
{
    public  string NextLevel;
    
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()) {

            
           
            LevelManager.Instance.setstatus(SceneManager.GetActiveScene().name, LevelStatus.completed);
            LevelManager.Instance.setstatus(NextLevel,LevelStatus.unlocked);
            SceneManager.LoadScene(NextLevel);            
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
