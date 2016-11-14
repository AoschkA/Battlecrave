using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
    public float movementSpeed = 4f;
    public float turnSmoothing = 15f; // A smoothing value for turning the player.

    private Animator animator;
    Vector3 movement;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLength = 100f;

	void Awake() {
        floorMask = LayerMask.GetMask("Floor");
        animator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }
	
	void Update() {
        Turn();
        Move();
    }
	void Move() {
        Vector3 movement = new Vector3(0f,0f,0f);

        if (Input.GetKey(KeyCode.W)) {
            movement += transform.forward * Time.deltaTime * movementSpeed;
        } if (Input.GetKey(KeyCode.S)) {
            movement -= transform.forward * Time.deltaTime * movementSpeed;
        } if (Input.GetKey(KeyCode.A)) {
            movement -= transform.right * Time.deltaTime * movementSpeed;
        } if (Input.GetKey(KeyCode.D)) {
            movement += transform.right * Time.deltaTime * movementSpeed;
        }

        playerRigidbody.MovePosition(transform.position + movement);
        
    }

    // Turn based on mouse cursor
    void Turn() {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRigidbody.MoveRotation(newRotation);
        }
    }
}
