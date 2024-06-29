using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public GameObject one_t;
    public GameObject two_t;
    public GameObject three_t;
    public Text time_text;
    public bool boo;
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public bool end = false;
    public GameObject[] water_g;
    public Text score;
    public float s;
    public float m;
    public float h = 0;
    public Text S;
    // Start is called before the first frame update
    void Start()
    {
        //time_text.text = timer.ToString();
        one_t.SetActive(true);
        two_t.SetActive(true);
        three_t.SetActive(true);
        score.text = "";
       
    }
  
    
    void Update()
    {
        if(s > 60)
        {
            s = 0;
            m += 1;
        }
        else
        {
            s += .01f;
        }
        S.text = m.ToString()+": "+s.ToString();
        if (end)
        {
            if(one & two & three)
            {
                score.text = "YOU WIN";
                S.text = "Time: " + m.ToString() + ": " + s.ToString();
            }
            else
            {
                score.text = "YOU LOSE";
                print(one);
                print(two);
                print(three);
                 
            }
        }
    }
}