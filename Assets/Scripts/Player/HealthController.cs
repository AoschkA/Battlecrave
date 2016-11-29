using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{
    public int PlayerHealth;
    private bool isDamaged;
    private bool isDead;
    private bool isImmune;

    private EnemyHealth enemyHealth;


    void Start()
    {
 
    }
	// Use this for initialization
	void Awake ()
	{
	    PlayerHealth = 100;
	    enemyHealth = GetComponent<EnemyHealth>();
        isImmune = false;

	}

    public void GetHit(int damage)
    {
        if (!isImmune) {
            isDamaged = true;
            PlayerHealth -= damage;

            CheckIfDead();
        }

    }

    public void CheckIfDead()
    {
        if (PlayerHealth >= 0)
        {
            isDead = true;
        }
    }

    public IEnumerator MakeImmune(float time) {
        isImmune = true;
        Debug.Log("immune");
        yield return new WaitForSeconds(time);
        isImmune = false;
        Debug.Log("not immune");
        yield return null;
        
    }


}
