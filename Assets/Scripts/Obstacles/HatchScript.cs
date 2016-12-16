using UnityEngine;
using System.Collections;

public class HatchScript : MonoBehaviour {
	private bool open; 
	private bool openIsUnset; 
	public GameObject turnAroundPoint;
	private int hatchID;
	private GameObject player;
	private bool isPlayerCollidingHatch;

	// Use this for initialization
	void Start () {
		openIsUnset = true;


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			openIsUnset = false;
			if (open) {
				open = false;
			} else if (!open) {
				open = true;
			}

		}
		if (open && !openIsUnset) {
			
			// -2 and +2 due to the fact that I don't want hatches to open to 90 degrees, this allows difference Δxz to find either top,left,right or bottom hatch.
			//Top
			if (turnAroundPoint.transform.position.z-2 > transform.position.z && turnAroundPoint.transform.position.x == transform.position.x)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.left, 90 * Time.deltaTime);
			//Bottom
			if (turnAroundPoint.transform.position.z+2 < transform.position.z && turnAroundPoint.transform.position.x == transform.position.x)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.right, 90 * Time.deltaTime);
			//Right
			if (turnAroundPoint.transform.position.x-2 > transform.position.x && turnAroundPoint.transform.position.z == transform.position.z)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.forward, 90 * Time.deltaTime);
			//Left
			if (turnAroundPoint.transform.position.x+2 < transform.position.x && turnAroundPoint.transform.position.z == transform.position.z)
				transform.RotateAround (turnAroundPoint.transform.position, Vector3.back, 90 * Time.deltaTime);	
		}
	
		if (open == false && !openIsUnset) {
			//Top, first and second part of the if sentance describes if it is a hatch, third part secures that it is only rotated to match the floor.
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

	public bool GetIsHatchOpen(){
		return open;
	}

	public void SetIsHatchOpen(bool isOpen){
		open = isOpen;
		openIsUnset = false;
	}
		
}
