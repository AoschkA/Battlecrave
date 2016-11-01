using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject gamePlane;

	// Use this for initialization
	void Start ()
	{
	    Vector3 gamePlanePosition = gamePlane.transform.position;
	    Vector3 gamePlaneCenter;
	    gamePlaneCenter.x = gamePlanePosition.x/2;
	    gamePlaneCenter.y = gamePlanePosition.y/2;
	    gamePlaneCenter.z = gamePlanePosition.z/2;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
