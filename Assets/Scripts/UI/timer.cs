using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour {
    public static int gametime;
    float gametimef = 0;
    public Text tt;

	// Use this for initialization
	void Start () {
         gametimef = 0;

	}
	
	// Update is called once per frame
	void Update () {
         gametimef += Time.deltaTime;
        //if (gametime < 60)
        gametime =(int) (gametimef * 100);
            tt.text = "Time: " + setTimetostring(gametime);


    }
    string setTimetostring(int t)

    {
        

        string time = "";
        int hh = t / 360000;
        int mm = (t - (hh * 360000)) / 6000;
        int ss = (t - (hh * 360000) - (mm * 6000)) / 100;
        int mil = (t - (hh * 360000) - (mm * 6000) - (100 * ss));
        time = time + valtostring(hh);
        time = time + ":";
        time = time + valtostring(mm);
        time = time + ":";
        time = time + valtostring(ss);
        time = time + ":";
        time = time + valtostring(mil);
        return time;
    }
    string valtostring(int val)
    {
        string tb = "";
        if (val < 10)
        {
            tb = "0" + val.ToString();
        }
        else tb =val.ToString();

        return tb;
    }
}
