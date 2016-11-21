using UnityEngine;
using System.Collections;

public class ArcaneBoltController : MonoBehaviour {
    public float arcaneBoltSpeed = 7;
    public GameObject hitPrefab;

    private GameObject player;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player") {
            // Hit player
            Destroy(this.gameObject);
        }
        if (other.gameObject.name == "Floor") {
            // Hit floor
            Instantiate(hitPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

    }
}
