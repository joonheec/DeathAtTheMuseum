using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	
	public float moveSpeed;
	public static bool hasKettle = false;
	private Animator anim;
	private static bool playerExists;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		if (!playerExists) {
			playerExists = true;
			DontDestroyOnLoad (transform.gameObject);

		} else {
			Destroy (gameObject);
		}
		
	}
	
	// Update is called once per frame	
	void Update () {
		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));
		}
		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
			transform.Translate (new Vector3 (0f,Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime,0f));
		}
		anim.SetFloat ("moveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("moveY", Input.GetAxisRaw ("Vertical"));
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Clue") {
			Debug.Log ("Clue collision");
			Debug.Log (col.gameObject);
			hasKettle = true;
			Debug.Log ("Has Kettle");
			Destroy(col.gameObject);

			Debug.Log ("Destroyed");


		}
	} 
}
	