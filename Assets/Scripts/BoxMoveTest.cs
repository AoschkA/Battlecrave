using UnityEngine;
using System.Collections;

public class BoxMoveTest : MonoBehaviour {
	
	public float thrust;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("w"))
			rb.AddForce(Vector3.forward * thrust);
		if (Input.GetKeyDown("a"))
			rb.AddForce(Vector3.left * thrust);
		if (Input.GetKeyDown("d"))
			rb.AddForce(Vector3.right * thrust);
		if (Input.GetKeyDown("s"))
			rb.AddForce(Vector3.back * thrust);
	}
}
