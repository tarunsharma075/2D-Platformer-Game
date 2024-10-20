using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollowing : MonoBehaviour
{

    public  float followspeed = 2f;
    public Transform target;
    public float yoffset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x, target.position.y+yoffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, followspeed*Time.deltaTime);
    }
}
