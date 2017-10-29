using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class l2_TreeUIManager : MonoBehaviour {

	public Slider healthBar;
	public Text HTText;
	public l2_TreeHealthManager treeHealth;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.maxValue = treeHealth.treeMaxHealth;
		healthBar.value = treeHealth.treeCurrentHealth;

		string vidaActual = treeHealth.treeCurrentHealth.ToString();
		string vidaMax = treeHealth.treeMaxHealth.ToString();
		HTText.text = "Vida del bosque : " + vidaActual + " / " +  vidaMax;
//		HPText.text = "Bosque: " + treeHealth.treeCurrentHealth + "/" + treeHealth.treeMaxHealth; 
	}
}
