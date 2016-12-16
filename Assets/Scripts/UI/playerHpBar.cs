using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerHpBar : MonoBehaviour {
    float maxHp = 100;
    float currentHp = 45;
     HealthController unit;
    public GameObject bar, player;
    public Text hptext;

	// Use this for initialization
	void Start () {
         unit = player.GetComponent<HealthController>();
        maxHp = unit.PlayerHealth;
    }
	
	// Update is called once per frame
	void Update () {
        currentHp = unit.PlayerHealth;
        bar.transform.localScale = new Vector3(currentHp, transform.localScale.y, transform.localScale.z);
        hptext.text = currentHp + "%";


    }
}
