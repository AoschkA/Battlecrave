using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class setName : MonoBehaviour {
    public InputField IF;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setPlayer()
    {
        GameStats.playerName = IF.text;
    }
}
