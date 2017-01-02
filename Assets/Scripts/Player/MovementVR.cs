using UnityEngine;
using System.Collections;

public class MovementVR : MonoBehaviour {
	public float movementSpeed = 4f;
	public float turnSmoothing = 15f; // A smoothing value for turning the player.

	private Animator animator;
	Vector3 movement;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 100f;
	GameObject camera;
	GameObject playerModel;


	// Use this for initialization
	void Start () {
		floorMask = LayerMask.GetMask("Floor");
		animator = GetComponent<Animator>();
		playerRigidbody = GetComponent<Rigidbody>();
		camera = this.gameObject.transform.GetChild(2).gameObject;
		playerModel = this.gameObject.transform.GetChild(0).gameObject;


	}
	
	// Update is called once per frame
	void Update () {
		Move();
		Turn ();
	}



	void Move() {
		// Grab this frame's input from the GearVR pad.
		float moveX = Input.GetAxis("Mouse X");
		float moveY = Input.GetAxis("Mouse Y");
		Debug.Log ("X: " + moveX);
		Debug.Log ("Y: " + moveY);


		// Define local vectors based on where I'm facing
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		Vector3 backward = transform.TransformDirection(Vector3.back);
		Vector3 left = transform.TransformDirection(Vector3.left);
		Vector3 right = transform.TransformDirection(Vector3.right);

		Vector3 movement = new Vector3(0f,0f,0f);

		if (Input.GetMouseButton(0) && moveX == 0 && moveY == 0) {
			movement += camera.transform.forward * Time.deltaTime * movementSpeed;
		} /*else if (moveY < -0.1 && Input.GetMouseButtonDown(0)) {
			movement -= transform.forward * Time.deltaTime * movementSpeed;
		} if (moveX > 0.1 && Input.GetMouseButtonDown(0)) {
			movement -= transform.right * Time.deltaTime * movementSpeed;
		} else if (moveX < -0.1 && Input.GetMouseButtonDown(0)) {
			movement += transform.right * Time.deltaTime * movementSpeed;
		}*/

		playerRigidbody.MovePosition(transform.position + movement);

	}

	void Turn(){
		Ray camRay = Camera.main.ScreenPointToRay(camera.transform.forward);

		RaycastHit floorHit;

		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;

			Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

			playerModel.transform.rotation = newRotation;

			//playerModelRB.MoveRotation (newRotation);

		


		}
	}

}
