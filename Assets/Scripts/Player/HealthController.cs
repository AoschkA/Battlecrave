using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{
    private int PlayerHealth;
    private bool isDamaged;
    private bool isDead;

    private EnemyHealth enemyHealth;



	// Use this for initialization
	void Awake ()
	{
	    PlayerHealth = 100;
	    enemyHealth = GetComponent<EnemyHealth>();

	}
	
	// Update is called once per frame
	public void Update () {
	
	}

    public void GetHit(int damage)
    {
        isDamaged = true;
        PlayerHealth -= damage;

        CheckIfDead();

    }

    public void CheckIfDead()
    {
        if (PlayerHealth >= 0)
        {
            isDead = true;
        }
    }


}
