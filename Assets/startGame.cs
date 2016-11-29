using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void changeScene(){

         if(GameStats.bossname == "Warrok")


         SceneManager.LoadScene("TestScene_01 - Copy");
        
        
    }

}
