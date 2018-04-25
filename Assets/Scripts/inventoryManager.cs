using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryManager : MonoBehaviour {
	private GameObject inventory;
	private bool invIsOpen;
	// Use this for initialization
	void Start () {
		inventory = this.gameObject;
		inventory.SetActive (false);
		invIsOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update");
		if (invIsOpen) {
			if (Input.GetKeyDown (KeyCode.I)) {
				inventory.SetActive (false);
				invIsOpen = false;
			}
			
		} else if (!invIsOpen) {	
			if (Input.GetKeyDown (KeyCode.I)) {
				inventory.SetActive (true);
				invIsOpen = true;
			}
		}
	}
}
