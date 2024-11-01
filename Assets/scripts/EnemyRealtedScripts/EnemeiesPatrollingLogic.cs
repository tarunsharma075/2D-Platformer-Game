using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeiesPatrollingLogic : MonoBehaviour
{
    public Transform[] PatrolingPoints;
    public float EnemySpeed;
    public int PatrolDestination;
    void Update()
    {
        if (PatrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolingPoints[0].position, EnemySpeed*Time.deltaTime);
            if(Vector2.Distance(transform.position, PatrolingPoints[0].position) < .2f)
            {

                transform.localScale=  new Vector3(1, 1, 1);
                PatrolDestination = 1;

            }
        }



        if (PatrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolingPoints[1].position, EnemySpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PatrolingPoints[1].position) < .2f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                PatrolDestination = 0;
            }
        }

    }
}
