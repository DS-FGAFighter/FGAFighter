using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerEnergyPlayerOne : MonoBehaviour {

	private Rigidbody2D rb2d;
	private bool isGrounded;

	public Animator animator;
	public Collider2D col;
	public float moveSpeed;
	public float jumpPower;
	private bool facingRight;
    private Slider player1Slider;
    //private Slider player2Slider;
    //private Rigidbody2D player1;
    //private Rigidbody2D player2;
    private float globalCooldown;

    private float attack1Cooldown;
    private float attack1AnimationCooldown;
    public bool attack1Animation;
    public Rigidbody2D bullet;
    private Vector3 fixedBulletPosition;

    void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
		animator = GetComponent<Animator> ();
		moveSpeed = 1.5f;
		jumpPower = 200f;
		isGrounded = true;
        facingRight = true;

        attack1Animation = false;

        // Get Player 1 Slider
        GameObject temp = GameObject.FindWithTag("Player1Slider");
        if (temp != null)
        {
            player1Slider = temp.GetComponent<Slider>();
            // Debug.Log(slider.value);
        }

        // Get Player 2 Slider
        //GameObject temp2 = GameObject.FindWithTag("Player2Slider");
        //if (temp2 != null)
        //{
        //    player2Slider = temp2.GetComponent<Slider>();
        //}

        // Get Player 1 Component
        //GameObject temp3 = GameObject.FindWithTag("Player1Energy");
        //if (temp3 != null)
        //{
        //    player1 = temp3.GetComponent<Rigidbody2D>();
        //}

        // Get Player 2 Component
        //GameObject temp4 = GameObject.FindWithTag("Player2");
        //if (temp4 != null)
        //{
        //    player2 = temp4.GetComponent<Rigidbody2D>();
        //}

        // Bullet
        GameObject temp5 = GameObject.FindWithTag("Player1EnergyAttack");
        if (temp5 != null)
        {
            bullet = temp5.GetComponent<Rigidbody2D>();
        }

        player1Slider.value = 100f;
    }
    
    void FixedUpdate() {

        float horizontal = Input.GetAxis ("Horizontal");

		HandleMovement (horizontal);
		Flip (horizontal);
        fixBulletPosition();

        animator.SetBool("attack1Animation", attack1Animation);

        animator.SetFloat("moveSpeed", Mathf.Abs(horizontal));

		if (Input.GetKey (KeyCode.W) && isGrounded) {
			rb2d.AddForce (Vector2.up * jumpPower);
			isGrounded = false;
        }

        if (Input.GetKey(KeyCode.G))
        {
            AttackOne();
        }
        if (attack1AnimationCooldown <= Time.time)
        {
            attack1Animation = false;
        }
    }

	private void HandleMovement(float horizontal) {
		rb2d.velocity = new Vector2(horizontal * moveSpeed,  rb2d.velocity.y);
	}

	private void Flip(float horizontal) {
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;

			theScale.x *= -1;

			transform.localScale = theScale;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			isGrounded = true;
		}
    }

    void AttackOne()
    {
        if (globalCooldown <= Time.time && attack1Cooldown <= Time.time)
        {
            globalCooldown = Time.time + 0.5f;
            attack1Cooldown = Time.time + 2f;
            attack1AnimationCooldown = Time.time + 1f;
            attack1Animation = true;

            Rigidbody2D bulletInstance = Instantiate(bullet, fixedBulletPosition, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
            //bulletInstance.velocity = transform.TransformDirection(new Vector3(0, 0, 200f));
            if(facingRight)
            {
                bulletInstance.AddForce(Vector2.right * 150f);
            }
            else
            {
                bulletInstance.AddForce(Vector2.left * 150f);
            }
            
            //bulletInstance.velocity = transform.forward * 2f;

            Physics2D.IgnoreCollision(bulletInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        // Debug.Log(player1Slider.value);
    }

    void fixBulletPosition()
    {
        fixedBulletPosition.y = (transform.position.y) + 0.125f;
        fixedBulletPosition.z = (transform.position.z);

        if (facingRight)
        {
            fixedBulletPosition.x = (transform.position.x) + 0.2f;
        }
        else
        {
            fixedBulletPosition.x = (transform.position.x) - 0.2f;
        }
    }

}