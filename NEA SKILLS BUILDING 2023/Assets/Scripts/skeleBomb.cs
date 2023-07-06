using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeleBomb : MonoBehaviour {

	string direction;
	float movementSpeed;
	public float activeDistance;

	// Use this for initialization
	void Start () {
		direction = "right";
		movementSpeed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == "right") {
			transform.Translate (Vector3.right * Time.deltaTime * movementSpeed);
			transform.localScale = new Vector3 (1, 1, 1);
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.right, activeDistance);
			Debug.DrawRay (transform.position, Vector2.right * activeDistance);
		} else if (direction == "left") {
			transform.Translate (Vector3.left * Time.deltaTime * movementSpeed);
			transform.localScale = new Vector3 (-1, 1, 1);
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.left, activeDistance);
			Debug.DrawRay (transform.position, Vector2.left * activeDistance);
		}
	}


	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "leftMarker") {
			direction = "right";
		} else if (other.gameObject.tag == "rightMarker") {
			direction = "left";
		}
	}
}
