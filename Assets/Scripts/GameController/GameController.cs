using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    private PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;

    // Use this for initialization
    void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
