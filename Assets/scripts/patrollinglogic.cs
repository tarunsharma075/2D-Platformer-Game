using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrollinglogic : MonoBehaviour
{
    public Transform[] patrolingpoints;
    public float enemyspeed;
    public int patroldestination;
    void Update()
    {
        if (patroldestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolingpoints[0].position, enemyspeed*Time.deltaTime);
            if(Vector2.Distance(transform.position, patrolingpoints[0].position) < .2f)
            {

                transform.localScale=  new Vector3(1, 1, 1);
                patroldestination = 1;

            }
        }



        if (patroldestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolingpoints[1].position, enemyspeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolingpoints[1].position) < .2f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                patroldestination = 0;
            }
        }

    }
}
