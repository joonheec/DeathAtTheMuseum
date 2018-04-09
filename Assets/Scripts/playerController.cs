using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	
	public float moveSpeed;
	private bool hasKettle = false;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
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
			Destroy (col.gameObject);
			hasKettle = true;
			Debug.Log ("Has Kettle");

		}
	} 
}
