using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMovement : MonoBehaviour {

	Rigidbody2D rb;
	float speed;
	public int lives;
	bool vulnerable;
	public int score;
	public int highScore;
	bool immune;
	SpriteRenderer spriteRender;


	// Use this for initialization
	void Start () {
		speed = 5.1f;
		lives = 3;
		vulnerable = false;
		immune = false;
		rb = GetComponent<Rigidbody2D> ();
		spriteRender = GetComponent<SpriteRenderer> ();
		score = 0;
		highScore = PlayerPrefs.GetInt ("highScore");
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

	void scoreIncrease()
	{
		if (this.gameObject != null) {
			score += 100;
			if (score > highScore) {
				highScore = score;
			}
			Debug.Log (score);
		}
	}

	void bigScoreIncrease()
	{
		if (this.gameObject != null) {
			score += 200;
			if (score > highScore) {
				highScore = score;
			}
			Debug.Log (score);
		}
	}

	public void setLives(){
		if(immune == false){
		lives -= 1;
		immune = true;
			spriteRender.color = Color.magenta;
		StartCoroutine ("immuneTimer");

			if (lives <= 0 || vulnerable == true) {
				Debug.Log ("End of game");
				PlayerPrefs.SetInt ("Score", score);
				PlayerPrefs.SetInt ("highScore", highScore);
				SceneManager.LoadScene ("Lost");
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag == "extraLife") {
			lives += 1;
			Destroy (other.gameObject);
		} else if (other.gameObject.tag == "vulnerable") {
			Destroy (other.gameObject);
			vulnerable = true;
			Debug.Log ("vulnerable = true!");
			StartCoroutine ("VulnerableDeBuff");
		} else if (other.gameObject.tag == "boom") {
			Destroy (other.gameObject);
			setLives ();
		}
	}

	IEnumerator VulnerableDeBuff()
	{
		yield return new WaitForSeconds (5f);
		vulnerable = false;
		Debug.Log ("vulnerable = false!");
	}
	IEnumerator immuneTimer()
	{
		yield return new WaitForSeconds (2f);
		spriteRender.color = Color.white;
		immune = false;
	}


}
