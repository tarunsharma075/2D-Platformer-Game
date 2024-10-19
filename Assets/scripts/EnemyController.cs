using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float enemyspeed;
    public string restart_level;
    public  scorerefresh sr;
    private  int score= 0;
    public Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("player is killed");
            animator.SetTrigger("dead");
            StartCoroutine(RestartAfterAnimation());



        }




    }
    private IEnumerator RestartAfterAnimation()
    {
        // Wait for the animation to finish (adjust the time to match the length of your death animation)
        yield return new WaitForSeconds(2.0f); // Change 2.0f to the actual length of your animation

        // Then reload the scene
        SceneManager.LoadScene(restart_level);
        sr.increasescore(score);
    }


    private void Update()
    {
        Vector3 pos = transform.position;
        pos.x += enemyspeed * Time.deltaTime;
        transform.position = pos;
    }
}
