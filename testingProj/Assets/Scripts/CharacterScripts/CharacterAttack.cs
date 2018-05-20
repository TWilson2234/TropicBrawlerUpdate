using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttack : MonoBehaviour {

	Animator rHandAnim;
	public Camera charCam;
	public float range;
	public LayerMask myLayerMask;
	private GameObject enemy;
	private int shovelDamage = 10;


	// Use this for initialization
	void Awake () {
		rHandAnim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {


		Attack();
		
	}

	void Attack(){
		if(Input.GetMouseButtonDown(0)) {
			rHandAnim.Play("playerRightAttack");

			RaycastHit hit;
			if (Physics.Raycast(charCam.transform.position, charCam.transform.forward, out hit, range, myLayerMask)) {
				enemy = hit.transform.gameObject;
				if(enemy != null && enemy.gameObject.tag == "Enemy") {
					print("Enemy hit");
					enemyDamage();
				}
			}

		} 
	}

	void enemyDamage() {

		enemy.GetComponent<EnemyHealth>().TakeDamage(shovelDamage);


	}
		
}
