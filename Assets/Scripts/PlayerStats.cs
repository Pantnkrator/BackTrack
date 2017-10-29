using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public int currentLevel;
	public int currentExp;
	public int[] toLevelUp;

	public int[] HPLevel;
	public int[] attackLevel;
	public int[] defenseLevel;

	public int currentHP;
	public int currentDefense;
	public int currentAttack;


	private PlayerHealthManager thePlayerHealth;

	// Use this for initialization
	void Start () {
		currentHP = HPLevel [1];
		currentAttack = attackLevel [1];
		currentDefense = defenseLevel [1];

		thePlayerHealth = FindObjectOfType<PlayerHealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentExp >= toLevelUp [currentLevel]) {
			LevelUp ();

		}
	}
	public void addExperience(int experienceToAdd){
		currentExp += experienceToAdd;
	}

	public void LevelUp(){
		currentLevel++;
		currentHP = HPLevel [currentLevel];
		thePlayerHealth.playerMaxHealth = currentHP;
		thePlayerHealth.playerCurrentHealth += currentHP - HPLevel [currentLevel - 1];
		currentAttack = attackLevel [currentLevel];
		currentDefense = defenseLevel [currentLevel];
	}
}
