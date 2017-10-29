using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l2_TreeHealthManager : MonoBehaviour {

	public int treeMaxHealth;
	public int treeCurrentHealth;
	//public GameObject originalTree;

	// Use this for initialization
	void Start () {
		SetMaxHealth ();
		//treeCurrentHealth = treeMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (treeCurrentHealth <= 0) {
			//gameObject.SetActive (false);
			//print("--------------FIN----------------");
		}
		
	}

	public void HurtTree(int damageToGive){
		treeCurrentHealth -= damageToGive;
		//print ("salud : " + treeCurrentHealth);
	}
	public void SetMaxHealth(){
		treeCurrentHealth = treeMaxHealth;
	}

	public void prueba(){
		print ("ALV!!!");
	}


}
