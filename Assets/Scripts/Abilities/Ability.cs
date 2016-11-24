using UnityEngine;
using System.Collections;

public abstract class Ability : MonoBehaviour {
    public double cooldown;

    public abstract void UseAbility();

    public abstract void Animate();
}
