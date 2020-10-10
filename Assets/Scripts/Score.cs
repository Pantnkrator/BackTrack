using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	public InputField name;
	public Text score;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Post(){
		Application.OpenURL ("https://pantnkrator.github.io/score?score="+score.text+"&name="+name.text);
	}
}
