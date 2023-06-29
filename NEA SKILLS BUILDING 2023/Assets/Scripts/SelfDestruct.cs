using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 5);
		GetComponent<Rigidbody2D> ().AddForce (new Vector2(Random.Range(-1f,1f), Random.Range(-2f,0f)), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDestroy() {
		Debug.Log ("A bomb was destroyed");
	}
}
