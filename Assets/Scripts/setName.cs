using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class setName : MonoBehaviour
{
    public InputField IF;
    public Dropdown ab1dd, ab2dd, ab3dd;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setPlayer()
    {
        GameStats.playerName = IF.text;
    }
    public void setab1()
    {
        string ab = ab1dd.captionText.text;
        GameStats.ab1 = ab;
    }
    public void setab2()
    {
        GameStats.ab2 = ab2dd.captionText.text; ;
    }
    public void setab3()
    {
        GameStats.ab3 = ab3dd.captionText.text; ;
    }
}
