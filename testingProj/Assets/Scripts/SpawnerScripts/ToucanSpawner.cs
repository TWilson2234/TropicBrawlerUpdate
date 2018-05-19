using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucanSpawner : MonoBehaviour {

	GameObject ToucanPrefab;
	float delaySecs = 3f;
	float delayTimer;
	Transform spawnLoc;

	int waveCounter;

	// Use this for initialization
	void Awake () {
		spawnLoc = this.gameObject.transform;
		print (spawnLoc);
		ToucanPrefab = Resources.Load ("Toucan_Full") as GameObject;
		print (ToucanPrefab.name + " " + ToucanPrefab.tag);


	}

	// Update is called once per frame
	void Update () {

		if (Time.time >= delayTimer) {
			Instantiate (ToucanPrefab, spawnLoc);
			delayTimer = Time.time + delaySecs;
		}


	}
}
