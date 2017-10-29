﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Animator anim;
	private Rigidbody2D myRididbody;

	private bool playerMoving;
	private Vector2 lastMove;

	private bool attacking;
	public float attackTime;
	private float attackTimeCounter;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myRididbody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		playerMoving = false;
		if (!attacking) {
			
			if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
				//transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));

				myRididbody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed, myRididbody.velocity.y);
				playerMoving = true;
				lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
			}
			if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) {
				//transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
				myRididbody.velocity = new Vector2 (myRididbody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed);
				playerMoving = true;
				lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
			}
			

			if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) {
				myRididbody.velocity = new Vector2 (0f, myRididbody.velocity.y);
			}

			if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) {
				myRididbody.velocity = new Vector2 (myRididbody.velocity.x, 0f);
			}

			if (Input.GetKeyDown (KeyCode.J)) {
				attackTimeCounter = attackTime;
				attacking = true;
				myRididbody.velocity = Vector2.zero;
				anim.SetBool ("Attack", true);
			}
		}
		if (attackTimeCounter > 0) {
			attackTimeCounter -= Time.deltaTime;
		}
		if (attackTimeCounter <= 0) {
			attacking = false;
			anim.SetBool ("Attack", false);
		}

		anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
		anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);
	}
}
