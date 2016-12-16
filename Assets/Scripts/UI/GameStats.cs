using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{

    public static GameStats Instance;
    public static string difficult = "Easy";
    public static string bossname = "Warrok";
    public static int timer;

    public static string playerName = "Player";
    public static string gun;
    public static string armor;
    public static string ab1 ="blink";
    public static string ab2 = "heal";
    public static string ab3 = "immunity";
    public static string status = "lose";
    void Awake()
    {
        playerName = PlayerPrefs.GetString("playerName", "player");
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);

        }
    }
    public void setDifficult(Dropdown name)
    {

        difficult = name.captionText.text;
    }
    public void setbossname(Dropdown name)
    {
        bossname = name.captionText.text; ;
    }
    public void setname(InputField name)
    {
        playerName = name.text;
    }
    public void setgun(Dropdown name)
    {
        gun = name.captionText.text;
    }
    public void setArmor(Dropdown name)
    {
        armor = name.captionText.text;
    }
    public void setab1(Dropdown name)
    {
        ab1 = name.captionText.text;
    }
    public void setab2(Dropdown name)
    {
        ab2 = name.captionText.text;
    }
    public void setab3(Dropdown name)
    {
        ab3 = name.captionText.text;
    }
    public string getbossname()
    {
        return bossname;
    }
    public string getdifficult()
    {
        return difficult;
    }



}
