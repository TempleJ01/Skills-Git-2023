using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawner : MonoBehaviour {

	public GameObject bomb;
	public GameObject bouncyBomb;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", Random.Range(2f,5f), Random.Range(2f,4f));
		InvokeRepeating ("bounceSpawn", Random.Range(10f,30f), Random.Range(10f,25f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn() {
		Instantiate (bomb, (this.gameObject.transform.position), Quaternion.identity);
	}

	void bounceSpawn() {
		Instantiate (bouncyBomb, (this.gameObject.transform.position), Quaternion.identity);
	}
}
