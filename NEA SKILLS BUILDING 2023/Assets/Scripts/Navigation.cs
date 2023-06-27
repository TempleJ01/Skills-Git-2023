using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Navigation : MonoBehaviour {

	private Canvas mainCanvas;
	public TextMeshPro timer;

	// Use this for initialization
	void Start () {
		mainCanvas = GameObject.FindObjectOfType<Canvas> ();
		mainCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timer.text = Time.fixedTime.ToString ("0.00");

		if (Input.GetKey (KeyCode.Escape)) {
			mainCanvas.enabled = true;
			Time.timeScale = 0f;
		}
	}

	public void ClickedButtonA(){
		
		Debug.Log ("Button A Clicked!");
		PlayerPrefs.SetString ("WhichButtonClicked", "A");
		SceneManager.LoadScene ("PlayerPrefs");
	}

	public void ClickedButtonB(){

		Debug.Log ("Button B Clicked!");
		PlayerPrefs.SetString ("WhichButtonClicked", "B");
		SceneManager.LoadScene ("PlayerPrefs");
	}

	public void ClickedButtonC(){

		Debug.Log ("Exit Clicked!");
		Time.timeScale = 1;
	}
}
