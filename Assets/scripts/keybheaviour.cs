using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keybheaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController ps = collision.gameObject.GetComponent<PlayerController>();
            ps.pickup();
            Destroy(gameObject);
        }
    }
}
