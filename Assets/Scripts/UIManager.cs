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


	public Text HP;
	public Text damage;
	public Text defense;
	public Text exp;
	public Text expNext;
	public Text lvl;
	//by antoine para cargar lvl
	public static bool UIExists;

	public GameObject pauseUI;
	public GameObject statsUI;


	private bool isPause;

	private bool showStats;


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
		pauseUI.SetActive (false);
		statsUI.SetActive (false);
		isPause = false;
		showStats = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(UIExists){
			healthBar.maxValue = playerHealth.playerMaxHealth;
			healthBar.value = playerHealth.playerCurrentHealth;
			HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth; 
			lvlText.text = "Lvl: " + thePS.currentLevel;	 
		}
		if(Input.GetKeyDown(KeyCode.B)) {
			showStats = !showStats;
			if (showStats) {
				statsUI.SetActive (true);
				lvl.text = "Lvl: " + thePS.currentLevel;
				HP.text = "HP: " + playerHealth.playerMaxHealth;
				damage.text = "Damagae: " + (thePS.currentAttack+5);
				defense.text = "Defense: " + thePS.currentDefense;
				exp.text = "EXP: " + thePS.currentExp;
				expNext.text = "EXP to Next lvl: " + thePS.toLevelUp [thePS.currentLevel];
			} else {
				statsUI.SetActive (false);
			}
		}
		if ( Input.GetKeyDown(KeyCode.Escape)) {
			isPause = !isPause;
			if (isPause) {
				Time.timeScale = 0;
				pauseUI.SetActive (true);
			} else {
				Time.timeScale = 1;
				pauseUI.SetActive (false);
			}

		}
	}
	public void Resume(){
		isPause = false;
		Time.timeScale = 1;
		pauseUI.SetActive (false);
	}
	public void Reload(){
		Time.timeScale = 1;
		pauseUI.SetActive (false);
		Application.LoadLevel(Application.loadedLevel);
	}
	public void MainMenu(){
		Application.LoadLevel(0);
	}
	public void Quit(){
		Application.Quit ();
	}
	public void Score(){
		Time.timeScale = 1;
		pauseUI.SetActive (false);
		Application.LoadLevel (7);
	}
}
