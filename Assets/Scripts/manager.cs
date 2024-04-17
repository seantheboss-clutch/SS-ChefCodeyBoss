using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    /*public bool up_true = true;
    public bool space = false;*/
   /* public GameObject squirt;*/
   /* public Vector3 fount_pos = new Vector3(-69.63f,-41.25f,6.47f);*/
    //public GameObject cup;
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
    public GameObject cup;

    // Start is called before the first frame update
    void Start()
    {
        time_text.text = timer.ToString();
        droplet.SetActive(false);
        Timer();
    }
    void Timer()
    {
        while(timer > 0)
        {
            timer -= 1/10;
            time_text.text = Mathf.Floor(timer).ToString();
            if(timer < 0) 
            {
                Disable(); 
                break;
            }
        } 
    }
    void Disable()
    {

        one_t.text = "";
        two_t.text = "";
        three_t.text = "";
    }
    void Update()
    {
        if (one)
        {
            one_t.text = "1";
        }
        if (two)
        {
            droplet.SetActive(true);
            droplet.transform.position = new Vector3(cup.transform.position.x + .25f,cup.transform.position.y + 1, cup.transform.position.z); ;
            two_t.text = "1";
        }
        if (three)
        {
            three_t.text = "1";
        }
    }
}