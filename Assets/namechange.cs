using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class namechange : MonoBehaviour {


    public Text nt;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        nt.text = "Hello " + GameStats.playerName;
	}
}
