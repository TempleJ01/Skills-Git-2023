using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayBounce : MonoBehaviour {

	Rigidbody2D bomb;
	public float floatHeight;
	public float liftForce;
	public float damping;
	public float activeDistance;

	// Use this for initialization
	void Start () {
		bomb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down, activeDistance);
		Debug.DrawRay (transform.position, Vector2.down * activeDistance);

		if (hit.collider != null) {
			float distance = Mathf.Abs (hit.point.y - transform.position.y);
			float heightError =(floatHeight - distance);
			float force = liftForce * heightError - bomb.velocity.y * damping;
			bomb.AddForce (Vector3.up * force);
		}
	}
		
}

