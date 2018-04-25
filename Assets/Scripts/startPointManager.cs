using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startPointManager : MonoBehaviour {
	
	public int spawnPoint;
	public GameObject[] spawnPoints;
	public GameObject spawn;
	// Use this for initialization
	void Start () {
		if (spawnPoint == 1) {
			spawn = GameObject.Find ("spawnPoint1");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 2) {
			spawn = GameObject.Find ("spawnPoint2");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 3) {
			spawn = GameObject.Find ("spawnPoint3");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 4) {
			spawn = GameObject.Find ("spawnPoint4");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 5) {
			spawn = GameObject.Find ("spawnPoint5");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 6) {
			spawn = GameObject.Find ("spawnPoint6");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 7) {
			spawn = GameObject.Find ("spawnPoint7");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 8) {
			spawn = GameObject.Find ("spawnPoint8");
			spawn.SetActive (true);
		}
		else if (spawnPoint == 0) {
			spawn = GameObject.Find ("spawnPoint");
			spawn.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
