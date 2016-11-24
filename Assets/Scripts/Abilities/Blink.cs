using UnityEngine;
using System.Collections;
using System;

public class Blink : Ability {
    public int blinkAmount;

    GameObject player;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void UseAbility() {
        player.transform.position += Vector3.forward * blinkAmount;
    }

    public override void Animate() {
        throw new NotImplementedException();
    }
}
