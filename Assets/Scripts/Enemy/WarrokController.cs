using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public class WarrokController : MonoBehaviour {
    public GameObject arcaneBoltPrefab;
    public GameObject meteorRainPrefab;

    private Animator anim;
    private long trigger = 0;
    private GameObject player;
    private GameObject arcaneBolt;
    private System.Random rnd;

    void Awake() {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        arcaneBolt = GameObject.FindGameObjectWithTag("Arcane Bolt");
        rnd = new System.Random();
    }
	void Update () {
        trigger++;
        if (trigger % 200 == 0) {
            int attackNumber = rnd.Next(1, 5);
            Animate(attackNumber);
        }

        // Rotate boss
        transform.LookAt(player.transform.position, Vector3.up);

    }

    void Animate(int attackNumber) {
        Debug.Log("trigger");
        if (attackNumber == 1) {
            anim.SetTrigger("punch");
        }
        if (attackNumber == 2) {
            anim.SetTrigger("swipe");
        }
        if (attackNumber == 3) {
            anim.SetTrigger("flex");
        }
    }

    void ArcaneBolt() {
        Vector3 position = player.transform.position;
        position.y = position.y + 30;
        Instantiate(arcaneBoltPrefab, position, Quaternion.Euler(0f, 0f, 0f));
    }

    void MeteorRain() {
        Instantiate(meteorRainPrefab, new Vector3(0f,0f,0f), Quaternion.Euler(0f,0f,0f));
    }
}
