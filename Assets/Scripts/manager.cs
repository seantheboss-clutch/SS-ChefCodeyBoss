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
        if (two)
        {
            water_g[0].SetActive(false);
            water_g[1].SetActive(false);
            
        }
        if(end)
        {
            if(one & two & three)
            {
                score.text = "YOU WIN";
            }
            else
            {
                score.text = "YOU LOSE";
            }
        }
    }
}