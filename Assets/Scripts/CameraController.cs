using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject gamePlane;
	public GameObject player;
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
		Vector3 playerPosition = player.transform.position;
		directionFromCenter = (playerPosition - gamePlaneCenter).normalized;
		Vector3 cameraNewPosition = new Vector3 (directionFromCenter.x * 13, 5, directionFromCenter.z * 13);

			/*
		transform.position.x = directionFromCenter.x * 13;
		transform.position.z = directionFromCenter.z * 13;
		transform.position.y = 5;
*/
		transform.position = cameraNewPosition;
		transform.LookAt (gamePlaneCenter);


	}
}
