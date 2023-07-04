using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncyBomb : MonoBehaviour {

	GameObject Hero;

	// Use this for initialization
	void Start () {
		Hero = GameObject.FindGameObjectWithTag ("Player");
		Destroy (this.gameObject, 10);
		GetComponent<Rigidbody2D> ().AddForce (new Vector2(Random.Range(-2f,2f), Random.Range(-5f,0f)), ForceMode2D.Impulse);
	}

	// Update is called once per frame
	void Update () {

	}

	private void OnDestroy() {
		Hero.SendMessage ("bigScoreIncrease", SendMessageOptions.DontRequireReceiver);
		Debug.Log ("A blue bomb was destroyed");

	}
}