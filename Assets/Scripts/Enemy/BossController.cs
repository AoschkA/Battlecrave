using System;
using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {
    public int startingHealth = 5500;
    private int currentHealth;
    private bool isDead = false;

    private ParticleSystem hitParticles;

    public void TakeDamage(int amount, Vector3 hitPoint) {

        if (isDead) return;

        currentHealth -= amount;

        hitParticles.transform.position = hitPoint;
        hitParticles.Play();

        if (currentHealth <= 0) {
            Death();
        }

    }
    void Death() {
        isDead = true;

        //CapsuleCollider.isTrigger = true;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet") {
            Debug.Log("Hit");
            Destroy(col.gameObject);
        }
    }
}
