using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawner : MonoBehaviour {

	public GameObject bomb;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawner", 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawner() {
		Instantiate (bomb, new Vector3 (34, 10, 0), Quaternion.identity);
	}
}
