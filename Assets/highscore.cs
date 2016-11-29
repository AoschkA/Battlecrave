using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
    public string boss;
    public string diff;
    public string name;
    public Text giText;
    string t;
    int newHigh;

    // Use this for initialization
    void Start() {
        //PlayerPrefs.DeleteAll(); // clean highscore
        if (GameStats.status.Equals("win"))
        {
            Debug.Log("updating score");
            int tempInt = 0;
            string current = "";
            string tempPlayer="";
            for (int i = 1; 11 > i; i++)
            {
                int highscore = PlayerPrefs.GetInt("highscore" + i + boss + diff, 9999999);
                Debug.Log("maybe high " + highscore);
                if (highscore> GameStats.timer )
                {
                    Debug.Log("maybe high");
                    if (tempInt == 0)
                    {
                        tempPlayer = PlayerPrefs.GetString("highscore" + i, "player");
                        tempInt = highscore;
                        PlayerPrefs.SetInt("highscore" + i + boss + diff, GameStats.timer);
                        tempPlayer = PlayerPrefs.GetString("highscore" + i, "player");
                        PlayerPrefs.SetString("highscore" + i, GameStats.playerName);
                        Debug.Log("a change");
                        tempInt = highscore;
                        
                    }
                    else
                    {
                        PlayerPrefs.SetInt("highscore" + i + boss + diff, tempInt);
                        tempInt = highscore;
                        current = PlayerPrefs.GetString("highscore" + i, "player");
                        PlayerPrefs.SetString("highscore" + i, tempPlayer);
                        tempPlayer = current;
                    }
                }
                
            }
            GameStats.status = "lose";
            onChange();
       }


        boss = GameStats.bossname;
        diff = GameStats.difficult;
        t = "";
        t = boss + " - " + diff+ "\n \n";
        for (int i = 1; 11 > i; i++) {
            int highscore = PlayerPrefs.GetInt("highscore" + i + boss + diff, 9999999);

            string tim = setTimetostring(highscore);


            string player = PlayerPrefs.GetString("highscore" + i, "player");

            if (i != 10) t = t + i + ".   " + tim + " - " + player + "\n"; else t = t + i + ". " + tim + " - " + player + "\n";


        }
        giText.text = t;

 }
    public void onChange()
    {
        boss = GameStats.bossname;
        diff = GameStats.difficult;
        t = "";
        t = boss + " - " + diff + "\n \n";
        for (int i = 1; 11 > i; i++)
        {
            int highscore = PlayerPrefs.GetInt("highscore" + i + boss + diff, 0);

            string tim = setTimetostring(highscore);


            string player = PlayerPrefs.GetString("highscore" + i, "player");

            if (i != 10) t = t + i + ".   " + tim + " - " + player + "\n"; else t = t + i + ". " + tim + " - " + player + "\n";


        }
        giText.text = t;
    }
    // Update is called once per frame
    void Update () {

	
	}
    string setTimetostring(int t)
        
    {
        string time="";
        int hh = t / 360000;
        int mm = (t - (hh * 360000)) / 6000;
        int ss = (t - (hh * 360000) -(mm*6000) )/ 100;
        int mil = (t - (hh * 360000) - (mm * 6000)-( 100*ss));
        time = time+ valtostring(hh);
        time= time + ":";
        time = time + valtostring(mm);
        time = time + ":";
        time = time + valtostring(ss);
        time = time + ":";
        time = time + valtostring(mil);


        return time;
    }
    string valtostring(int val)
    {
        string tb= "";
        if (val < 10)
        {
            return "0" + val.ToString();
        }else return val.ToString();



    }
}
