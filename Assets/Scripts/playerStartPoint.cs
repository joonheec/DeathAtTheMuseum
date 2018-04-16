﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStartPoint : MonoBehaviour {
	private playerController thePlayer;
	private CameraFollow theCamera;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<playerController> ();
		thePlayer.transform.position = transform.position;
		theCamera = FindObjectOfType<CameraFollow> ();
		theCamera.transform.position = new Vector3 (transform.position.x, transform.position.y, theCamera.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
