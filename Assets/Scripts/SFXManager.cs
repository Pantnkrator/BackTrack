using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

	public AudioSource playerHurt;
	public AudioSource PlayerDead;
	public AudioSource PlayerAttack;

	private bool sfxManExists;
	// Use this for initialization
	void Start () {
		if (!sfxManExists) {
			sfxManExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
}
