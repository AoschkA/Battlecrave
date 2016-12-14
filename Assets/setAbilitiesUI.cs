using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setAbilitiesUI : MonoBehaviour {


    RawImage imgab1, imgab2, imgab3;
    public Texture flash, heal, immune;
    // Use this for initialization
    void Start()
    {
        imgab1 = GameObject.Find("Canvas/abilities/imgab1").GetComponent<UnityEngine.UI.RawImage>();
        imgab1.texture = findAblilty(GameStats.ab1);
        imgab2 = GameObject.Find("Canvas/abilities/imgab2").GetComponent<UnityEngine.UI.RawImage>();
        imgab2.texture = findAblilty(GameStats.ab2);
        imgab3 = GameObject.Find("Canvas/abilities/imgab3").GetComponent<UnityEngine.UI.RawImage>();
        imgab3.texture = findAblilty(GameStats.ab3);

    }

    // Update is called once per frame
    void Update()
    {

    }
    Texture findAblilty(string ab)
    {

        switch (ab)
        {
            case "heal":
                return heal;
                break;
            case "blink":
                return flash;
                break;
            case "immunity":
                return immune;
                break;

        }
        return immune;

    }
}
