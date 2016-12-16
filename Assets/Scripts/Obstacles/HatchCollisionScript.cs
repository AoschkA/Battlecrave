using UnityEngine;
using System.Collections;

public class HatchCollisionScript : MonoBehaviour {
	private bool isPlayerCollidingHatch;
	public GameObject hatch;
	private HatchScript hs;
	private GameObject floor;
	private MeshCollider floorCollider;


	// Use this for initialization
	void Start () {
		hs = (HatchScript)hatch.GetComponent (typeof(HatchScript));
		floor = GameObject.FindGameObjectWithTag ("Floor");
		floorCollider = floor.GetComponent<MeshCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider playerCollision){
		if (playerCollision.gameObject.tag == "Player") {
			isPlayerCollidingHatch = true;
			Debug.Log ("Entering collision with player (Hatch)");
			if (hs.GetIsHatchOpen())
				floorCollider.enabled = false;
			else
				floorCollider.enabled = true;

		}
	}

	void OnTriggerExit(Collider playerCollision){
		if (playerCollision.gameObject.tag == "Player") {
			isPlayerCollidingHatch = false;
			Debug.Log ("Exiting collision with player (Hatch)");
			floorCollider.enabled = true;
		}
	}

	public bool GetIsPlayerCollidingHatch(){
		return isPlayerCollidingHatch;
	}
}
