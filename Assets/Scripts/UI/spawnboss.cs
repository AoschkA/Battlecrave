using UnityEngine;
using System.Collections;

public class spawnboss : MonoBehaviour {

	// Use this for initialization

        public GameObject bossObj1;
    public GameObject bossObj2;
    public GameObject spawnpoint;
    GameObject tempfap;

    void Start () {
        //GameStats.bossname;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void spawn()
    {
        
            Destroy(tempfap);
            if ("Warrok" == GameStats.bossname)
            {
                tempfap = Instantiate(bossObj1, spawnpoint.transform.position, spawnpoint.transform.rotation) as GameObject;

            }
            if ("Pikachu" == GameStats.bossname)
            {
                tempfap = Instantiate(bossObj2, spawnpoint.transform.position, spawnpoint.transform.rotation) as GameObject;

            }
        
    }
}
