using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerController : MonoBehaviour
{
    public float runSpeed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundcheck;
    public float checkRadius;
    public LayerMask whatIsGround;
 
    private float ExtraJumps;
    public float ExtraJumpsValues;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        {
            ExtraJumps = ExtraJumpsValues;
            animator.SetBool("isJumping", false);
        }
        if (Input.GetButtonDown("Jump") && ExtraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            ExtraJumps--;
            animator.SetBool("isJumping", true);
        }
        else if(Input.GetButtonDown("Jump") && ExtraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            animator.SetBool("isJumping", true);
        }
        moveInput = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(moveInput));
    }
    void FixedUpdate(){
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatIsGround);
        rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput <0)
        {
            Flip();
        }
    }
    void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
