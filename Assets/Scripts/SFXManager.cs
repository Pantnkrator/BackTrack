using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {


	public AudioSource PlayerHurt;
	public AudioSource PlayerDead;
	public AudioSource PlayerAttack;

	private static bool sfxmanExists;

	// Use this for initialization
	void Start () {
		if (!sfxmanExists) {
			sfxmanExists = true;
			DontDestroyOnLoad (transform.gameObject); 
		} 
		else {
			Destroy (gameObject); 
		}
	}
}
