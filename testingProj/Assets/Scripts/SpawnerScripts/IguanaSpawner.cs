using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaSpawner : MonoBehaviour {

	GameObject IguanaPrefab;
	float delaySecs = 2f;
	float delayTimer;
	Transform spawnLoc;

	int waveCounter;

	// Use this for initialization
	void Awake () {
		spawnLoc = this.gameObject.transform;
		print (spawnLoc);
		IguanaPrefab = Resources.Load ("Iguana_Full") as GameObject;
		print (IguanaPrefab.name + " " + IguanaPrefab.tag);


	}

	// Update is called once per frame
	void Update () {

		if (Time.time >= delayTimer) {
			Instantiate (IguanaPrefab, spawnLoc);
			delayTimer = Time.time + delaySecs;
		}


	}
}
