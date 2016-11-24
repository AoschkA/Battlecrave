using UnityEngine;
using System.Collections;
using System;

public class Immunity : Ability {
    public int duration;

    GameObject player;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void UseAbility() {
        throw new NotImplementedException();
    }

    public override void Animate() {
        throw new NotImplementedException();
    }
}
