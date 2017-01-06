using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
    private GameObject boss;
    private BossController bossHealth;

    void Awake()
    {
        boss = GameObject.FindGameObjectWithTag("Boss");
        bossHealth = boss.GetComponent<BossController>();

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Boss") {
            Debug.Log("Hit");
            bossHealth.TakeDamage(500,transform.position);
            Destroy(gameObject);

        }
    }
}
