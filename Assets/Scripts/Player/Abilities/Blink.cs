﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Blink : Ability {
    public int blinkAmount;
    public GameObject particle;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        if (GameStats.ab1 == "blink")
            cooldownText = GameObject.Find("Canvas/abilities/cdtext1").GetComponent<UnityEngine.UI.Text>();
        if (GameStats.ab2 == "blink")
            cooldownText = GameObject.Find("Canvas/abilities/cdtext2").GetComponent<UnityEngine.UI.Text>();
        if (GameStats.ab3 == "blink")
            cooldownText = GameObject.Find("Canvas/abilities/cdtext3").GetComponent<UnityEngine.UI.Text>();
    }

    public override void UseAbility() {
        if (timeRemaining == 0) {
            timeStamp = Time.time + cooldown;
            Animate();
            player.transform.position += player.transform.forward * blinkAmount;
            Animate();
        }
    }

    public override void Animate() {
        GameObject temp = Instantiate(particle, player.transform.position, player.transform.rotation) as GameObject;
        Destroy(temp, 2f);
    }

    void Update() {
        if (timeStamp >= Time.time) {
            timeRemaining = timeStamp - Time.time;
            cooldownText.fontSize = 20;
            int cooldownToInt = (int)timeRemaining + 1;
            cooldownText.text = cooldownToInt.ToString();
        } else {
            timeRemaining = 0;
            cooldownText.fontSize = 10;
            cooldownText.text = "READY";
        }
    }
}
