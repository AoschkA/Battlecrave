using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bossHpBar : MonoBehaviour
{
    float maxHp = 100;
    float currentHp = 45;
    BossController unit;
    public GameObject bar, player;
    public Text hptext;

    // Use this for initialization
    void Start()

    {
        unit = player.GetComponent<BossController>();
        maxHp = unit.startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float procenthp = (currentHp * 100) / maxHp;
        currentHp = unit.currentHealth;
        bar.transform.localScale = new Vector3(procenthp, transform.localScale.y, transform.localScale.z);
        hptext.text = procenthp + "%";


    }
}
