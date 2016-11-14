using UnityEngine;
using System.Collections;
using System.Timers;

public class WarrokController : MonoBehaviour {
    private Animator anim;
    private long trigger = 0;
    public Animation punch;

    void Awake() {
        anim = GetComponent<Animator>();

    }
	void Update () {
        trigger++;
        if (trigger % 400 == 0) {
            Animate();
        }

	}

    void Animate() {
        Debug.Log("trigger");
        anim.SetTrigger("punch");
    }

    void ArcaneBolt() {
        Debug.Log("punch");
    }
}
