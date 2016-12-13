using UnityEngine;
using System.Collections;

public class HatchScript : MonoBehaviour {
	GameObject floor;
	GameObject player;
	MeshCollider floorCollider;
	Rigidbody playerRigidBody;


	// Use this for initialization
	void Start () {
		floor = GameObject.FindGameObjectWithTag ("Floor");
		player = GameObject.FindGameObjectWithTag ("Player");
		floorCollider = floor.GetComponent<MeshCollider> ();
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			floorCollider.enabled = false;
			Debug.Log ("LUTZ");
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			floorCollider.enabled = true;
			Debug.Log ("LUTZ2");
		}
			
			
		
	}
}
