using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour {
	public Dialogue dialogue;
	public playerController controller;
	// Use this for initialization
	public void triggerDialogue (){
		FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
	}
//	public void triggerAltDialogue (){
//		FindObjectOfType<dialogueManager>().StartAltDialogue(dialogue);
//	}
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Players") {

				Debug.Log ("PlayerCollision");
				triggerDialogue ();
			}
//			} else if (controller.hasKettle) {
//				triggerAltDialogue ();
//			}
		}
}

