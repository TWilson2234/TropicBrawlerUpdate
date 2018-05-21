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
	public static bool isAttacking;


	// Use this for initialization
	void Awake () {
		rHandAnim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {


		Attack();
		
	}

	void Attack(){
		RaycastHit hit;
		if(Physics.Raycast(charCam.transform.position, charCam.transform.forward, out hit, range, myLayerMask)) {
			enemy = hit.transform.gameObject; 
			print(enemy.name);
		}

		if(Input.GetMouseButtonDown(1) ) {
			rHandAnim.Play("playerRightAttack");
			isAttacking = true;
//			RaycastHit hit;
//			if (Physics.Raycast(charCam.transform.position, charCam.transform.forward, out hit, range, myLayerMask)) {
//				enemy = hit.transform.gameObject;
			if(enemy != null && enemy.gameObject.tag == "Enemy") {
				enemyDamage(shovelDamage);
			}
//			}
			isAttacking = false;
		}

		if(Input.GetMouseButtonDown(0)) {
			isAttacking = true;

		}
	}

	void enemyDamage(int damage) {

		enemy.GetComponent<EnemyHealth>().TakeDamage(damage);


	}
		
}
