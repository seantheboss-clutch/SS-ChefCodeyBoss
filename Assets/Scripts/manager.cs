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
    public Text score;

    private void Start()
    {
        score.text = "";
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
            Invoke("start_again", 3f);
        }
        if (end)
        {
            if(one & two & three)
            {
                if(s < 90 && s >= 60 )
                {
                    score.text = "GOLD";
                }
                else if(s < 60 && s >= 30)
                {
                    score.text = "SILVER";
                }
                else
                {
                    score.text = "BRONZE";
                }
                SceneManager.LoadScene(0);

            }
            else
            {
                Lost();
                SceneManager.LoadScene(0);
            }
        }
        void Lost()
        {
            score.text = "YOU LOSE";
        }
    }
}