﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueHolder : MonoBehaviour {
	public string dialogue;
	private DialogueManager dMAn;
	public string[] dialogueLines;
	void Start () {
		dMAn = FindObjectOfType<DialogueManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){	
		if (other.gameObject.name == "Player") {
			if (Input.GetKeyUp(KeyCode.Space)) {
				//print ("entre!---");
				//dMAn.ShowBox (dialogue);
				if (!dMAn.dialogActive) {
					dMAn.dialogLines = dialogueLines;
					dMAn.currentLine = 0;
					dMAn.ShowDialogue ();
				}
				if (transform.parent.GetComponent<VillagerMovement> () != null) {
					transform.parent.GetComponent<VillagerMovement> ().canMove = false;
				}
			}
		}
	}
}
