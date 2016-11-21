using UnityEngine;
using System.Collections;
using UnityEditor;

public class AttackController : MonoBehaviour
{
    // Bullet emitter to shoot from.
    public GameObject BulletEmitter;

    // Actual bullet.
    public GameObject Bullet;

    // Speed.
    public float BulletForce;

    //ShootCooldown
    private bool ShootCooldown = false;
    private float CooldownTimeleft = 0.5f;

	// Use this for initialization
	public void Awake () {
	    
	}
	
	// Update is called once per frame
	public void Update () {
        if(ShootCooldown)
            StartShootCooldown();


	    if (!ShootCooldown)
	    {
	        if (Input.GetMouseButtonDown(0))
	        {
	            GameObject TempBullet;

	            TempBullet =
	                Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;



	            // Fail correction
	            //TempBullet.transform.Rotate(Vector3.left * 90);

	            // RigidBody
	            Rigidbody TempBulletRigidBody;
	            TempBulletRigidBody = TempBullet.GetComponent<Rigidbody>();

	            //Ignore collision between bullet and player.
	            //Physics.IgnoreCollision(TempBullet.GetComponent<Collider>(), this.gameObject.GetComponent<Collider>());

	            // Add force to bullet
	            TempBulletRigidBody.AddForce((transform.forward*BulletForce));

                

	            // Destroy
	            Destroy(TempBullet, 10.0f);

               

                ShootCooldown = true;


                }
	    }

	}

    public void StartShootCooldown ()
    {
        CooldownTimeleft -= Time.deltaTime;

        if (CooldownTimeleft < 0)
        {
            ShootCooldown = false;
            CooldownTimeleft = 0.5f;
        }


    }


}
