using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//comentario por Antoine

public class HurtPlayer : MonoBehaviour {

	public int damageToGive;
	public GameObject damageNumber;
	private int currentDamage;

	private PlayerStats thePS;

	// Use this for initialization
	void Start () {
		thePS = FindObjectOfType<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "Player") {
			currentDamage = damageToGive - thePS.currentDefense;
			other.gameObject.GetComponent<PlayerHealthManager> ().HurtPlayer (currentDamage);
			var clone = (GameObject)Instantiate (damageNumber, other.transform.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<FloatingNumbers> ().damegeNumber = currentDamage;
		}

	}
}
