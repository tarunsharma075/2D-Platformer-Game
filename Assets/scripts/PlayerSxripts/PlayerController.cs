using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator Animator;
    private Rigidbody2D _rbobj;
    public float Speed;
    public float JumpForce;
    public UiForScore ScoreController;
    public static int LevelIndex;
    [SerializeField] private UiFoeHealth _healthchange;
    private bool _isTrigger = false;
    
    

    private void Awake()
    {
        Animator = gameObject.GetComponent<Animator>();
        _rbobj = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float hvalue = Input.GetAxisRaw("Horizontal");
        float vvalue = Input.GetAxisRaw("Jump");

        PlayerAnimation(hvalue, vvalue);
        PlayerMovement(hvalue, vvalue);
    }

    private void PlayerAnimation(float horizontal, float vertical)
    {
        Animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Vector2 scale = transform.localScale;

        if (horizontal < 0f)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
           
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

        Animator.SetBool("jump", vertical > 0);
        Animator.SetBool("crouch", Input.GetKey(KeyCode.LeftControl));
    }

    private void PlayerMovement(float horizontal, float vertical)
    {
        Vector2 pos = transform.position;
        pos.x += Speed * horizontal * Time.deltaTime;
        transform.localPosition = pos;

        if (vertical > 0f) {

            _rbobj.AddForce(new Vector2(0f,JumpForce),ForceMode2D.Force);
        }
    }

   
   

    public void pickup()
    {
        ScoreController.IncreaseScore(10);
    }

    public void HealthLoss()
    {
        _healthchange.Damage();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>() != null)
        {
            _isTrigger = true;
            if (this.transform.position.x < 1)
            {
                this.transform.position = new Vector3(this.transform.position.x + 2, this.transform.position.y, this.transform.position.z);
            }
            else if (this.transform.position.x > 1)
            {
                this.transform.position = new Vector3(this.transform.position.x - 2, this.transform.position.y, this.transform.position.z);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>() != null)
        {
            Debug.Log("Exited Trigger with Enemy");
            _isTrigger = false; 
        }
    }


}
