using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyController : MonoBehaviour
{
    public float enemyspeed;
    public string restart_level;
    public scorerefresh sr;
    private int score = 0;
    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<playerhealthlogic>() != null)
        {
            playerhealthlogic.health--;
            if (playerhealthlogic.health <= 0)
            {
                animator.SetTrigger("dead");

                Invoke("changesence", 2f);
            }

        }
        else
        {
            StartCoroutine(GetHurt());
        }
    }

    private void changesence()
    {
        SceneManager.LoadScene(restart_level);
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.x += enemyspeed * Time.deltaTime;
        transform.position = pos;
    }


    IEnumerator GetHurt() {

        Physics.IgnoreLayerCollision(6,8);
        yield return new WaitForSeconds(2);
        Physics.IgnoreLayerCollision(6, 8,false);
    }
   
}
