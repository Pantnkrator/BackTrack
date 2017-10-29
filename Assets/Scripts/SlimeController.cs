﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {


	public float moveSpeed;
	private Rigidbody2D myRigibody;
	private bool moving;
	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;
	private Vector3 moveDirection;

	public float waitToReload;
	private bool reloading;

	private GameObject thePlayer;

	// Use this for initialization
	void Start () {
		myRigibody = GetComponent<Rigidbody2D> ();
		//timeBetweenMoveCounter = timeBetweenMove;
		//timeToMoveCounter = timeToMove;
		timeBetweenMoveCounter=Random.Range(timeBetweenMove*0.75f, timeBetweenMove*1.25f);
		timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeToMove * 1.25f);
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			timeToMoveCounter -= Time.deltaTime;
			myRigibody.velocity = moveDirection;
			if (timeToMoveCounter < 0) {
				moving = false;
				timeBetweenMoveCounter=Random.Range(timeBetweenMove*0.75f, timeBetweenMove*1.25f);
			}

		} else {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigibody.velocity = Vector2.zero;
			if (timeBetweenMoveCounter < 0f) {
				moving = true;
				timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeToMove * 1.25f);
				moveDirection = new Vector3 (Random.Range (-1f, 1f)*moveSpeed, Random.Range (-1f, 1f)*moveSpeed  , 0f);
			}
		}
		if (reloading) {
			waitToReload -= Time.deltaTime;
			if (waitToReload < 0) {
				Application.LoadLevel (Application.loadedLevel);
				thePlayer.SetActive (true);
			}
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		/*
		if (other.gameObject.name == "Player") {
			other.gameObject.SetActive(false);
			reloading = true;
			thePlayer = other.gameObject;
		}
		*/	
	}
}
