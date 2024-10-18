using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()!=null);
        Debug.Log("THE PLAYER COLLIDED WITH THE CHECKPPOINT OF END GAME");
    }
}
