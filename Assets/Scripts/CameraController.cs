using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject gamePlane;
	public GameObject player;
	public int cameraDistance = 13;
	//private GameObject camera;
	private Vector3 gamePlaneCenter;
	private Vector3 directionFromCenter;



	// Use this for initialization
	void Start ()
	{
		//gamePlane = GetComponent<GameObject> ();
		//camera = GetComponent<GameObject> ();
	   	
		findPlaneCenter ();




	}
	
	// Update is called once per frame
	void Update () {
		findCameraPosition ();
		Debug.Log (directionFromCenter);

	}

	void findPlaneCenter(){
		Vector3 gamePlanePosition = gamePlane.transform.position;

		gamePlaneCenter.x = gamePlanePosition.x/2;
		gamePlaneCenter.y = gamePlanePosition.y/2;
		gamePlaneCenter.z = gamePlanePosition.z/2;
	}

	void findCameraPosition(){
		// Find player position
		Vector3 playerPosition = player.transform.position;

		// Find direction from center to player
		directionFromCenter = (playerPosition - gamePlaneCenter).normalized;

		//New position, 13 indicates the distance, it is static, 5 indicates the height.
		Vector3 cameraNewPosition = new Vector3 (directionFromCenter.x * cameraDistance, 5, directionFromCenter.z * cameraDistance);

		// Lerping the position for better camera movement.
		Vector3 cameraPositionLerped = Vector3.Lerp(transform.position, cameraNewPosition, Time.deltaTime * 2);

			/*
		transform.position.x = directionFromCenter.x * 13;
		transform.position.z = directionFromCenter.z * 13;
		transform.position.y = 5;
*/
		//transform.position = cameraNewPosition;
		transform.position = cameraPositionLerped;
		transform.LookAt (gamePlaneCenter);


	}
}
