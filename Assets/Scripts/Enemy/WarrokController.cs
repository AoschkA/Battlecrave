﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class WarrokController : MonoBehaviour {
    public GameObject arcaneBoltPrefab;

    private Animator anim;
    private long trigger = 0;
    private GameObject player;
    private GameObject arcaneBolt;

    void Awake() {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        arcaneBolt = GameObject.FindGameObjectWithTag("Arcane Bolt");

    }
	void Update () {
        trigger++;
        if (trigger % 400 == 0) {
            Animate();
        }

        // Rotate boss
        transform.LookAt(player.transform.position, Vector3.up);

    }

    void Animate() {
        Debug.Log("trigger");
        anim.SetTrigger("punch");
    }

    void ArcaneBolt() {
        Vector3 position = player.transform.position;
        position.y = position.y + 30;
        Instantiate(arcaneBoltPrefab, position, arcaneBolt.transform.rotation);
        

    }
}