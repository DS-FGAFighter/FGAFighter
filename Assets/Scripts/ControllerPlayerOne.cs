using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayerOne : MonoBehaviour {

	private Rigidbody2D rb2d;
	private float playerHealth;
	private bool isGrounded;

	public Animator animator;
	public Collider2D col;
	public float moveSpeed;
	public float jumpPower;
	private bool facingRight;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
		animator = GetComponent<Animator> ();
		playerHealth = 100f;
		moveSpeed = 1.5f;
		jumpPower = 200f;
		isGrounded = true;
	}

	void FixedUpdate() {
		float horizontal = Input.GetAxis ("Horizontal");

		HandleMovement (horizontal);
		Flip (horizontal);
		animator.SetFloat("Speed", Mathf.Abs(horizontal));

		if (Input.GetKey (KeyCode.W) && isGrounded) {
			rb2d.AddForce (Vector2.up * jumpPower);
			isGrounded = false;
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

}