using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l2_hurtTree : MonoBehaviour {

	public int damageToGive;
	public GameObject originalTree;
	private int currentDamage;

	//private PlayerStats thePS;

	// Use this for initialization
	void Start () {
		//thePS = FindObjectOfType<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "Tree" || other.gameObject.tag.Equals("l2_tree")) {
			//originalTree.GetComponent<l2_thm> ().hurts ();
			//print("toco : " + this.name);
			originalTree.GetComponent<l2_TreeHealthManager> ().HurtTree (damageToGive);
		}
	}
}
