using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnimation : MonoBehaviour {

	Animator MyAnimator;
	// Use this for initialization
	void Start () {
		MyAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			MyAnimator.SetBool ("walk", true);
		} else {
			MyAnimator.SetBool ("walk", false);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			MyAnimator.SetBool ("dead", true);
		} else {
			MyAnimator.SetBool ("dead", false);
		}
	}
}
