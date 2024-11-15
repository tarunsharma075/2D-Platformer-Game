using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script is to make camera follow player i tried by making it player child obj
// but i am not getting the desired O/P thats why i used this script
public class PlayerFollowing : MonoBehaviour
{

    public  float FollowSpeed = 2f;
    public Transform Target;
    public float YOffSet = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(Target.position.x, Target.position.y+YOffSet, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, FollowSpeed*Time.deltaTime);
    }
}
