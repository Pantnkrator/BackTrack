﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	public Slider healthBar;
	public Text HPText;
	public PlayerHealthManager playerHealth;
	private PlayerStats thePS;
	public Text lvlText;


	// Use this for initialization
	void Start () {
		thePS = GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.maxValue = playerHealth.playerMaxHealth;
		healthBar.value = playerHealth.playerCurrentHealth;
		HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth; 
		lvlText.text = "Lvl: " + thePS.currentLevel;	 
	}
}
