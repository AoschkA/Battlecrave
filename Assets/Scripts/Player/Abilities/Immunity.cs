using UnityEngine;
using System.Collections;
using System;

public class Immunity : Ability {
    public int duration;
    public GameObject particle;
    private HealthController healthController;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        healthController = player.GetComponent<HealthController>();
        cooldownText = GameObject.Find("Canvas/ImmuneCooldownText").GetComponent<UnityEngine.UI.Text>();
    }

    public override void UseAbility() {
        if (timeRemaining == 0) {
            timeStamp = Time.time + cooldown;
            StartCoroutine(healthController.MakeImmune(duration));
            Animate();
        }
    }

    public override void Animate() {
        GameObject temp = Instantiate(particle, player.transform.position, player.transform.rotation) as GameObject;
        Destroy(temp, duration);
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
