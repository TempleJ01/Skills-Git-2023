using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LossScreen : MonoBehaviour {

	public TextMeshPro scoreDisplay;
	public TextMeshPro highScoreDisplay;

	// Use this for initialization
	void Start () {
		scoreDisplay.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
		highScoreDisplay.text = "High Score: " + PlayerPrefs.GetInt ("highScore").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RetryPressed() {
		SceneManager.LoadScene ("TEST");
	}
}
