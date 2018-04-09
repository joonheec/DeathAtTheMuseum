using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour {
	public Dialogue dialogue;
	// Use this for initialization
	public void triggerDialogue (){
		FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
	}
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name == "Player") {
				Debug.Log ("PlayerCollision");
				triggerDialogue ();
			
		}
	} 
}
