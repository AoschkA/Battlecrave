using UnityEngine;
using System.Collections;

public class ArcaneBoltController : MonoBehaviour {
    public float arcaneBoltSpeed = 7;
    public GameObject hitPrefab;

    private HealthController playerHealth;

    void Awake() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<HealthController>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player") {
            Instantiate(hitPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
            playerHealth.GetHit(5000);
        }
        if (other.gameObject.name == "Floor") {
            // Hit floor
            Instantiate(hitPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

    }
}
