using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcontroller : MonoBehaviour
{

    public string next_level;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()!=null);
        SceneManager.LoadScene(next_level);
    }
}
