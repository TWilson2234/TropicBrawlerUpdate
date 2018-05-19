using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabSpawner : MonoBehaviour {

	GameObject crabPrefab;
	float delaySecs = 1f;
	float delayTimer;
	Transform spawnLoc;

	int waveCounter;

	// Use this for initialization
	void Awake () {
		spawnLoc = this.gameObject.transform;
		print (spawnLoc);
		crabPrefab = Resources.Load ("Shell_Crab_Full") as GameObject;
		print (crabPrefab.name + " " + crabPrefab.tag);

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= delayTimer) {
			Instantiate (crabPrefab, spawnLoc);
			delayTimer = Time.time + delaySecs;
	}


	}
}
