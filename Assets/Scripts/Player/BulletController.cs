using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
    private EnemyHealth enemyHealth;
    // Use this for initialization
    void Start()
    {
        enemyHealth.GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   
}
