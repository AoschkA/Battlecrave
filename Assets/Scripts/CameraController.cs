using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public static GameObject gameCenter;
	public GameObject player;
	public int cameraDistance = 13;
	private Vector3 directionFromCenter;
	
	
    void Awake() {
        gameCenter = GameObject.FindGameObjectWithTag("Game Center");
    }

	void Update () {
		findCameraPosition ();
		Debug.Log (directionFromCenter);

	}

	void findCameraPosition(){
		// Find player position
		Vector3 playerPosition = player.transform.position;

		// Find direction from center to player
		directionFromCenter = (playerPosition - gameCenter.transform.position).normalized;

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
		transform.LookAt (gameCenter.transform.position);


	}
}
