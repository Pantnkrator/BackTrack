using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	public Slider healthBar;
	public Text HPText;
	public PlayerHealthManager playerHealth;
	private PlayerStats thePS;
	public Text lvlText;

	//by antoine para cargar lvl
	public static bool UIExists;	

	// Use this for initialization
	void Start () {
		thePS = GetComponent<PlayerStats> ();

		//by antoine para cargar lvl
		if (!UIExists) {
			UIExists = true;
			DontDestroyOnLoad (transform.gameObject);
		}
		else {
			Destroy (gameObject); 
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(UIExists){
			healthBar.maxValue = playerHealth.playerMaxHealth;
			healthBar.value = playerHealth.playerCurrentHealth;
			HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth; 
			lvlText.text = "Lvl: " + thePS.currentLevel;	 
		}
		
	}
}
