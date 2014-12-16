﻿using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour
{

		public float maxSpeed = 10f;
		bool facingRight = true;
		Animator anim;
		bool onGround = false;
		public Transform groundCheck;
		float groundRadius = 0.2f;
		public LayerMask whatIsGround;
		public float jumpForce = 700f;

		// Use this for initialization
		void Start ()
		{
				anim = GetComponent<Animator> ();
		}
	
		void FixedUpdate ()
		{
				onGround = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

				anim.SetBool ("Ground", onGround);

				anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);

				float move = Input.GetAxis ("Horizontal");

				anim.SetFloat ("Speed", Mathf.Abs (move));

				rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

				if (move > 0 && !facingRight)
						Flip ();
				else if (move < 0 && facingRight)
						Flip ();
		}

		// Update is called once per frame
		void Update ()
		{
				if (onGround && Input.GetKeyDown (KeyCode.Space)) {
						anim.SetBool ("Ground", false);
						rigidbody2D.AddForce (new Vector2 (0, jumpForce));
				}
		}

		void Flip ()
		{
				facingRight = !facingRight;
				Vector2 scale = transform.localScale;
				scale.x *= -1;
				transform.localScale = scale;
		}
}
