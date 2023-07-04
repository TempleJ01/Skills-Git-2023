using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	GameObject Hero;

	// Use this for initialization
	void Start () {
		Hero = GameObject.FindGameObjectWithTag ("Player");
		Destroy (this.gameObject, 4);
		GetComponent<Rigidbody2D> ().AddForce (new Vector2(Random.Range(-1f,1f), Random.Range(-5f,0f)), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDestroy() {
		Hero.SendMessage ("scoreIncrease", SendMessageOptions.DontRequireReceiver);
		Debug.Log ("A bomb was destroyed");



	}
}
