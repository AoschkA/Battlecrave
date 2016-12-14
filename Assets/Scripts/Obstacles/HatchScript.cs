using UnityEngine;
using System.Collections;

public class HatchScript : MonoBehaviour {
	private bool open; 
	private bool openIsUnset; 
	public GameObject turnAroundPoint;
	private int hatchID;

	// Use this for initialization
	void Start () {
		openIsUnset = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			openIsUnset = false;
			if (open)
				open = false;
			else if (!open)
				open = true;

		}
		if (open && !openIsUnset) {
			
			if (turnAroundPoint.transform.position.z-2 > transform.position.z && turnAroundPoint.transform.position.x == transform.position.x)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.left, 90 * Time.deltaTime);
			
			if (turnAroundPoint.transform.position.z+2 < transform.position.z && turnAroundPoint.transform.position.x == transform.position.x)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.right, 90 * Time.deltaTime);
			
			if (turnAroundPoint.transform.position.x-2 > transform.position.x && turnAroundPoint.transform.position.z == transform.position.z)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.forward, 90 * Time.deltaTime);
			
			if (turnAroundPoint.transform.position.x+2 < transform.position.x && turnAroundPoint.transform.position.z == transform.position.z)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.back, 90 * Time.deltaTime);	
		}
	
		if (open == false && !openIsUnset) {
			//Top
			if (turnAroundPoint.transform.position.z > transform.position.z && turnAroundPoint.transform.position.x == transform.position.x && transform.position.y<=0)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.right, 90 * Time.deltaTime);
			//Bottom
			if (turnAroundPoint.transform.position.z < transform.position.z && turnAroundPoint.transform.position.x == transform.position.x && transform.position.y<=0)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.left, 90 * Time.deltaTime);
			//Right
			if (turnAroundPoint.transform.position.x > transform.position.x && turnAroundPoint.transform.position.z == transform.position.z && transform.position.y<=0)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.back, 90 * Time.deltaTime);
			//Left
			if (turnAroundPoint.transform.position.x < transform.position.x && turnAroundPoint.transform.position.z == transform.position.z && transform.position.y<=0)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.forward, 90 * Time.deltaTime);	
		}
	}
}
