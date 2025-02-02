using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private bool isJumping = false;

    public float jumpForce = 10f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isRunning", true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            animator.SetTrigger("Jump");
            rb.linearVelocity = Vector2.up * jumpForce;
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        else if (collision.gameObject.CompareTag("Cactus"))
        {
            ResetGame();
        }
    }

    void ResetGame()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Paused");
    }
}