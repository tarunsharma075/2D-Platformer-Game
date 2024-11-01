using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    private static  GameManger _instance;
    public static GameManger Instance {  get { return _instance; } }



    private void Awake()
    {
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnClickForButtons(string Level)
    {
        SceneManager.LoadScene(Level);
    }
}
