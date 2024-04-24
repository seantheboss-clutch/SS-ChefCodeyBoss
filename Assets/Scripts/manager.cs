using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Text one_t;
    public Text two_t;
    public Text three_t;
    public Text time_text;
    public bool boo;
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public int timer = 3;
    public GameObject droplet;
    public GameObject[] water_g;
    // Start is called before the first frame update
    void Start()
    {
        droplet.GetComponent<Rigidbody>().useGravity = false;
        //time_text.text = timer.ToString();
       
    }
  
    
    void Update()
    {
        if (one)
        {
            one_t.text = "1";
        }
        if (two)
        {

            droplet.GetComponent<Rigidbody>().useGravity = true;
            water_g[0].SetActive(false);
            water_g[1].SetActive(false);
            two_t.text = "1";
            
        }
        if (three)
        {
            three_t.text = "1";
        }
    }
}