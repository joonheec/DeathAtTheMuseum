using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;
	public Animator animator;
	private static Queue<string> sentences;
	private static Queue<string> altSentences;
//	public playerController controller;



	// Use this for initialization
	void Start () {
		sentences = new Queue<string> ();
	
//		altSentences = new Queue<string> ();
	}



	public void StartDialogue(Dialogue dialogue){
		Debug.Log ("started");
		animator.SetBool ("IsOpen", true);
		nameText.text = dialogue.name;
		sentences.Clear ();
		Debug.Log ("cleared");

		if (playerController.hasKettle) {
			foreach (string altSentence in dialogue.altSentences) {
				sentences.Enqueue (altSentence);
			}
			Debug.Log ("started");
		} else {
			foreach (string sentence in dialogue.sentences) {
				sentences.Enqueue (sentence);
			}
		}
		DisplayNextSentence ();
	}


	public void DisplayNextSentence(){
		
		if (sentences.Count == 0) {
			EndDialogue ();
			return;
		}
		string sentence = sentences.Dequeue ();
		StopAllCoroutines ();
		StartCoroutine(TypeSentence (sentence));
//		dialogueText.text = sentence;

	}

	IEnumerator TypeSentence (string sentence){
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray()) {
			dialogueText.text += letter; 
			yield return null;
		}
	}

	void EndDialogue(){
		animator.SetBool ("IsOpen", false);

		Debug.Log ("End of convo");
	}
	// Update is called once per frame
}
