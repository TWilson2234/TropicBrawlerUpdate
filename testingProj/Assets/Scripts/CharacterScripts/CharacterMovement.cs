using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	private Rigidbody rb;
	float plrMoveSpd;
	public GameObject charCam;
	private float translation;
	private float straffe;

	public bool canJump = false;
	private float jumpforce =  20f;
	private float gravity = -45f;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {

		Movement ();
		GroundCheck();
		Jump();
	}

	void Movement() {
		//plrMoveSpd = 17f;
		Time.timeScale = 1;

		translation = Input.GetAxis("Vertical") * plrMoveSpd;
		straffe = Input.GetAxis("Horizontal") * plrMoveSpd;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		rb.transform.Translate(straffe, 0, translation);

		if (Input.GetKey(KeyCode.LeftShift)) {
			plrMoveSpd = 18f;
			print ("Sprint");
		} else {
			plrMoveSpd = 10f;
		}
	}

	void GroundCheck(){

		RaycastHit hit;
		Ray ray = new Ray(transform.position, -Vector3.up);
		Physics.Raycast(ray, out hit);
		float distToGround = hit.distance;

		if(distToGround < 1f) {
			canJump = true;
		} else {
			canJump = false;
		}
		
	}

	void Jump() {
		if(Input.GetKeyDown(KeyCode.Space) && canJump == true) {
			rb.velocity = new Vector3(0f, jumpforce, 0f);
		} else {
			rb.AddForce(0f, gravity, 0f);
		}
	}
		
}
