using UnityEngine;
using System.Collections;

public class AttackController : MonoBehaviour
{
    // Bullet emitter to shoot from.
    public GameObject Bullet_Emitter;

    // Actual bullet.
    public GameObject Bullet;

    // Speed.
    public float Bullet_Force;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        GameObject TempBullet;

	        TempBullet = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            

            // Fail correction
            //TempBullet.transform.Rotate(Vector3.left * 90);

            // RigidBody
	        Rigidbody TempBulletRigidBody;
	        TempBulletRigidBody = TempBullet.GetComponent<Rigidbody>();
            
            // Add force to bullet
            TempBulletRigidBody.AddForce((transform.forward * Bullet_Force) + new Vector3(0,300,0));

            // Destroy
            Destroy(TempBullet, 10.0f);




	    }
	
	}
}
