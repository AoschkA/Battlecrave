using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class winScrene : MonoBehaviour {
    public Text tt;
    // Use this for initialization
    void Start () {
        if (GameStats.status.Equals("win")) tt.text = "You Defeted " + GameStats.bossname;
        else tt.text = "You lost agaist " + GameStats.bossname;

    }
    void OnEnable()
    {
        if (GameStats.status.Equals("win")) tt.text = "You Defeted " + GameStats.bossname;
        else tt.text = "You lost agaist " + GameStats.bossname;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameStats.status.Equals("win")) tt.text = "You Defeted " + GameStats.bossname;
        else tt.text = "You lost agaist " + GameStats.bossname;

    }
}
