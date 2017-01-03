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
	private GameObject[] hatches;
	private HatchScript[] hatchscripts;
	private int numHatches = 4;

    void Awake() {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        arcaneBolt = GameObject.FindGameObjectWithTag("Arcane Bolt");
        rnd = new System.Random();

		hatches = new GameObject[numHatches];
		hatchscripts = new HatchScript[hatches.Length];
		hatches = GameObject.FindGameObjectsWithTag("Hatches");
		for (int i = 0; i < hatches.Length; i++) {
			hatchscripts [i] = hatches [i].GetComponent<HatchScript> ();
		}
    }
	void Update () {
        trigger++;
        if (trigger % 70 == 0) {
            int attackNumber = rnd.Next(1, 4);
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
        else if (attackNumber == 3) {
            anim.SetTrigger("flex");
        } else {
            anim.SetTrigger("punch");
        }
    }

    void ArcaneBolt() {
        Vector3 position = player.transform.position;
        position.y = position.y + 50;
        Instantiate(arcaneBoltPrefab, position, Quaternion.Euler(0f, 0f, 0f));
    }

    void MeteorRain() {
        Instantiate(meteorRainPrefab, new Vector3(0f,0f,0f), Quaternion.Euler(0f,0f,0f));
		OpenHatches ();
        StartCoroutine(CloseHatches());
    }

	void OpenHatches() {
		for (int i = 0; i < hatchscripts.Length; i++) {
			hatchscripts [i].SetIsHatchOpen (true);
			Debug.Log ("yes");
		}
	}
    IEnumerator CloseHatches() {
        yield return new WaitForSeconds(5);
        for (int i = 0; i < hatchscripts.Length; i++) {
            hatchscripts[i].SetIsHatchOpen(false);
        }
    }
}
