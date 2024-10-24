using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class PlayerController : MonoBehaviour
{
    // Class-level variable
    private Animator animator;
    private Rigidbody2D rbob;
    public float speed;
    public  float jumpforce;
    public scorerefresh scorecontroller;
    public  static int levelindex;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Initialize the animator component
        animator = gameObject.GetComponent<Animator>();
        rbob = gameObject.GetComponent<Rigidbody2D>();
        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        float hvalue = Input.GetAxisRaw("Horizontal");
        float Vvalur = Input.GetAxisRaw("Jump");
        playeranimatiion(hvalue, Vvalur);
        playermovement(hvalue, Vvalur);


    }

    private void playeranimatiion(float horizontal, float vertical)
    {
      

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Vector2 scale = transform.localScale;
        if (horizontal < 0f)
        {
            scale.x = -1f * Mathf.Abs(scale.x);

        }
        else if (horizontal > 0)
        {
            scale.x = MathF.Abs(scale.x);
        }
        transform.localScale = scale;

        if (vertical > 0)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("crouch", true);
        }else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouch", false);
        }

    }

    private void playermovement(float horizontal, float vertical)
    {
        Vector2 pos = transform.position;

        pos.x +=  speed * horizontal * Time.deltaTime;
        transform.localPosition = pos;


        if (vertical > 0)
        {

            rbob.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Force);

        }
    }

      public void pickup()
    {
        scorecontroller.increasescore(10);
    }
}
