using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour {

	public TextMeshPro gemCounter;
	GameObject[] totalGems;
	public TextMeshPro livesCounter;
	int lives;
	GameObject Hero;
	public TextMeshPro gameTimer;
	public TextMeshPro scoreCounter;
	GameObject timedBomb;
	int score;

	// Use this for initialization
	void Start () {
		Hero = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		lives = Hero.GetComponent<HeroMovement> ().lives;
		livesCounter.text = "Lives: " + lives;
		gameTimer.text = Time.timeSinceLevelLoad.ToString ("0.00");
		score = Hero.GetComponent<HeroMovement> ().score;
		scoreCounter.text = "Score: " + score;


		/*
		totalGems = GameObject.FindGameObjectsWithTag ("redGem");
		gemCounter.text = "Gems: " + totalGems.Length.ToString ();

		if (totalGems.Length == 0) {
			Hero.SendMessage ("SpawnAlter");
		}*/
	}
}

