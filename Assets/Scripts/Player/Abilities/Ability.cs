using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class Ability : MonoBehaviour {
    public float cooldown;
    public float timeRemaining = 0;
    protected float timeStamp;
    protected Text cooldownText;
    protected GameObject player;

    public abstract void UseAbility();

    public abstract void Animate();
}
