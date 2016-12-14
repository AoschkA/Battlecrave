using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{
    public int PlayerHealth;
    private bool isDamaged;
    private bool isDead;
    private bool isImmune;
    public GameObject deadhigh;
    public GameObject returnscreen;
    int maxhp;

    private EnemyHealth enemyHealth;


    void Start()
    {
        maxhp = PlayerHealth;
    }
	// Use this for initialization
	void Awake ()
	{
	    PlayerHealth = 100;
        maxhp = PlayerHealth;
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
    void Update()
    {
        CheckIfDead();
        if (PlayerHealth > maxhp) PlayerHealth = maxhp;
    }

    public void CheckIfDead()
    {
        if (0 >= PlayerHealth)
        {
            isDead = true;
            GameStats.status = "lost";
            deadhigh.SetActive(true);
            returnscreen.SetActive(true);
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
