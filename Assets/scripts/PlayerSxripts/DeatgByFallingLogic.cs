using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeatgByFallingLogic : MonoBehaviour
{
   
    private Scene _activeScene;
    int _activeSceneIndex;


    private void Start()
    {
        _activeScene = SceneManager.GetActiveScene();
        _activeSceneIndex = _activeScene.buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {

            
            SceneManager.LoadScene(_activeSceneIndex);

        }
    }
    
}
