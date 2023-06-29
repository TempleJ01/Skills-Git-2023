using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawner : MonoBehaviour {

	public GameObject bomb;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", Random.Range(2f,5f), Random.Range(5f,7f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn() {
		Instantiate (bomb, (this.gameObject.transform.position), Quaternion.identity);
	}
}
