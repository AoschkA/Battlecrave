using UnityEngine;
using System.Collections;
using System;

public class Heal : Ability {
    public int healAmount;
    public HealthController healthController;

    GameObject player;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        healthController = player.GetComponent<HealthController>();

    }

    public override void UseAbility() {
        healthController.PlayerHealth -= healAmount;
    }

    public override void Animate() {
        throw new NotImplementedException();
    }
}
