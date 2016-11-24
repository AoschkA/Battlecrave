using System;
using UnityEngine;
using System.Collections;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class BossController : MonoBehaviour {
    public int startingHealth = 5500;
    private int currentHealth;
    private bool isDead = false;

    private ParticleSystem hitParticles;

    public void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount, Vector3 hitPoint) {
        if (isDead) return;

        currentHealth -= amount;

        //hitParticles.transform.position = hitPoint;
        //hitParticles.Play();

        if (currentHealth <= 0) {
            Death();
        }

    }
    void Death() {
        Debug.Log("Dead");
        isDead = true;
        Destroy(this.gameObject);
        //CapsuleCollider.isTrigger = true;

    }
}
