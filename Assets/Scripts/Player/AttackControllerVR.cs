using UnityEngine;
using System.Collections;

public class AttackControllerVR : MonoBehaviour
{
    // Bullet emitter to shoot from.
    public GameObject BulletEmitter;

    // Actual bullet.
    public GameObject Bullet;

	GameObject camera;

    // Speed.
    public float BulletForce;

    //ShootCooldown
    private bool ShootCooldown = false;
    private float CooldownTimeleft = 0.5f;

	// Use this for initialization
	public void Awake () {
		camera = this.gameObject.transform.GetChild(2).gameObject;
	}

	// Update is called once per frame
	public void Update () {
        if(ShootCooldown)
            StartShootCooldown();

		float shootSwipeX = Input.GetAxis ("Mouse X");

		if (shootSwipeX < -0.4)
		{
	    
			if (!ShootCooldown)
			{
			
	            GameObject TempBullet;

	            TempBullet =
					Instantiate(Bullet, BulletEmitter.transform.position, camera.transform.rotation) as GameObject;



	            // Fail correction
	            //TempBullet.transform.Rotate(Vector3.left * 90);

	            // RigidBody
	            Rigidbody TempBulletRigidBody;
	            TempBulletRigidBody = TempBullet.GetComponent<Rigidbody>();

	            //Ignore collision between bullet and player.
	            //Physics.IgnoreCollision(TempBullet.GetComponent<Collider>(), this.gameObject.GetComponent<Collider>());

	            // Add force to bullet
				TempBulletRigidBody.AddForce((camera.transform.forward*BulletForce));

                

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
