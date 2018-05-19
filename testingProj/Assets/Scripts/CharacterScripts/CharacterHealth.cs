using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour {

	public float healthPoints = 100f;
	public CameraController camCon;
	public CharacterMovement charMove;

	private Animator charAnim;


	

	// Use this for initialization
	void Start () {
		charMove = GetComponent<CharacterMovement> ();
		camCon = this.GetComponentInChildren<CameraController>();
		charAnim = GetComponent<Animator>();

		
	}
	
	// Update is called once per frame
	void Update () {

		CheckHealth ();
		
	}

	void CheckHealth() {
		if(healthPoints > 0) {
			//healthPoints -= 1f;
			if (healthPoints <= 0) {
				//camCon.enabled = false; //Comment out to test
				//charMove.enabled = false; //
				//charAnim.SetBool("isDead", true); //
			}
		}
	}
}
