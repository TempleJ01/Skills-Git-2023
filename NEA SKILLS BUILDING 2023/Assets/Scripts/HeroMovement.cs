using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMovement : MonoBehaviour {

	Rigidbody2D rb;
	float speed;
	int lives;
	// Use this for initialization
	void Start () {
		speed = 5.1f;
		lives = 2;
		rb = GetComponent<Rigidbody2D> ();
			
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speed, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rb.AddForce (Vector2.up * 300);
		}
	}

	void resetPosition()
	{
		Debug.Log("SPIKED RECEIVED!");
		transform.SetPositionAndRotation (new Vector3 (-5.58f, 1.34f, 0), Quaternion.identity);
		setLives ();
	}

	public void setLives(){

		lives -= 1;

		if (lives <= 0) {
			Debug.Log ("End of game");
			SceneManager.LoadScene ("Lost");
		}
	}
}
