using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerPrefsOutput : MonoBehaviour {

	public TextMeshPro TxtOutput;

	// Use this for initialization
	void Start () {
		TxtOutput.text = PlayerPrefs.GetString ("WhichButtonClicked");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NavButtonClicked () {
		SceneManager.LoadScene("Navigation");
	}
}
