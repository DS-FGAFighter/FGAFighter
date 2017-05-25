using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerNinjaPlayerTwo : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private bool isGrounded;

    public Animator animator;
    public Collider2D col;
    public float moveSpeed;
    public float jumpPower;
    private bool facingRight;
    private Slider player1Slider;
    private Slider player2Slider;
    private Rigidbody2D player1;
    private Rigidbody2D player2;
    private float globalCooldown;

    public Rigidbody2D bullet;

    public bool attack1Animation;
    private float attack1AnimationCooldown;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
        animator = GetComponent<Animator>();
        moveSpeed = 1.5f;
        jumpPower = 200f;
        isGrounded = true;
        facingRight = false;

        // Get Player 1 Slider
        GameObject temp = GameObject.FindWithTag("Player1Slider");
        if (temp != null) {
            player1Slider = temp.GetComponent<Slider>();
            // Debug.Log(slider.value);
        }

        // Get Player 2 Slider
        GameObject temp2 = GameObject.FindWithTag("Player2Slider");
        if (temp2 != null)
        {
            player2Slider = temp2.GetComponent<Slider>();
        }

        // Get Player 1 Component
        GameObject temp3 = GameObject.FindWithTag("Player1Energy");
        if (temp3 != null)
        {
            player1 = temp3.GetComponent<Rigidbody2D>();
        }

        // Get Player 2 Component
        GameObject temp4 = GameObject.FindWithTag("Player2");
        if (temp4 != null)
        {
            player2 = temp4.GetComponent<Rigidbody2D>();
        }

        // Bullet
        GameObject temp5 = GameObject.FindWithTag("Player2EnergyAttack");
        if (temp5 != null)
        {
            bullet = temp5.GetComponent<Rigidbody2D>();
        }

        player2Slider.value = 100f;
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal2");

        HandleMovement(horizontal);
        Flip(horizontal);
        animator.SetFloat("moveSpeed", Mathf.Abs(horizontal));
        animator.SetBool("attack1Animation", attack1Animation);

        if (Input.GetKey(KeyCode.UpArrow) && isGrounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.Keypad1))
        {
            AttackOne();
        }

        if (attack1AnimationCooldown <= Time.time)
        {
            attack1Animation = false;
        }
    }

    private void HandleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * moveSpeed, rb2d.velocity.y);
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void AttackOne()
    {
        float dist = Vector3.Distance(player1.position, player2.position);

        attack1AnimationCooldown = Time.time + 1f;
        attack1Animation = true;

        if (globalCooldown <= Time.time && dist <= 0.35f)
        {
            //if(player2.position.x < player1.position.x && facingRight)
            //{
                player1Slider.value -= 5;
                globalCooldown = Time.time + 1f;
            //}
        }
        //Debug.Log(player1.position);
    }

}