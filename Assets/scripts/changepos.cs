using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepos : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>())
        {

            Debug.Log("detected");
        }
    }
}
