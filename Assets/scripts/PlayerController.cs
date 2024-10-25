using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rbob;
    public float speed;
    public float jumpforce;
    public scorerefresh scorecontroller;
    public static int levelindex;

    private bool isMoving = false;  // Movement tracking
    private bool isFootstepsPlaying = false;  // Footsteps tracking

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        rbob = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float hvalue = Input.GetAxisRaw("Horizontal");
        float vvalue = Input.GetAxisRaw("Jump");

        playeranimation(hvalue, vvalue);
        playermovement(hvalue, vvalue);
    }

    private void playeranimation(float horizontal, float vertical)
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
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

        animator.SetBool("jump", vertical > 0);
        animator.SetBool("crouch", Input.GetKey(KeyCode.LeftControl));
    }

    private void playermovement(float horizontal, float vertical)
    {
        Vector2 pos = transform.position;
        pos.x += speed * horizontal * Time.deltaTime;
        transform.localPosition = pos;

        // Check if player is moving horizontally
        if (horizontal != 0)
        {
            if (!isMoving)
            {
                isMoving = true;
                PlayFootsteps();  // Start footsteps sound
            }
        }
        else
        {
            if (isMoving)
            {
                isMoving = false;
                StopFootsteps();  // Stop footsteps sound
            }
        }

        if (vertical > 0)
        {
            rbob.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Force);
        }
    }

    // Method to play footsteps sound
    private void PlayFootsteps()
    {
        if (!isFootstepsPlaying)
        {
            isFootstepsPlaying = true;
            SoundManager.Instance.SoundEffects.loop = true;
            SoundManager.Instance.Play(SoundManager.sounds.PlayerMove);
        }
    }

    // Method to stop footsteps sound
    private void StopFootsteps()
    {
        isFootstepsPlaying = false;
        SoundManager.Instance.SoundEffects.loop = false;
        SoundManager.Instance.SoundEffects.Stop();
    }

    public void pickup()
    {
        scorecontroller.increasescore(10);
    }
}
