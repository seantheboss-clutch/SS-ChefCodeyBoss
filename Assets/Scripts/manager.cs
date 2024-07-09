using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public bool boo;
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public bool end = false;
    public float s;
    public float m;
    public float h = 0;
    public Text S;
    public Text gold;
    public Text silver;
    public Text bronze;
    public Text lost;
    private void Start()
    {
        lost.text = "";
    }
    void Update()
    {
        if (s <= 0)
        {
            s = 59;
            m -= 1;
        }
        else
        {
            s -= .01f;
        }
        if (s > 0 && s < 10)
        {
            S.text = m.ToString() + ": 0" + Mathf.Floor(s).ToString();
        }
        else
        {
            S.text = m.ToString() + ":" + Mathf.Floor(s).ToString();
        }
        if (m <= 0 && s <= 0)
        {
            Lost();
            Invoke("restart", 3f);
        }
        if (end)
        {
            if(one & two & three)
            {
                if (s < 90 && s >= 55)
                {                
                    prize(gold);
                }
                else if (s < 55 && s >= 30)
                {
                    prize(silver);
                }
                else
                {
                    prize(bronze);
                }

            }
            Invoke("restart", 5f);
        }
    }
    void Lost()
    {
        lost.text = "YOU LOSE";
    }

    void restart()
    {
        SceneManager.LoadScene(0);
    }
    void prize(Text medal_text)
    {
        medal_text.color = Color.magenta;
    }
}