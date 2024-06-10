using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public int time = 0;
    public int time2 = 0;
    public Text timer_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer(1000,"ChefCodey");
    }
    void Timer(int c, string scene)
    {
        while (time2 < c)
        {
            time++;
            time2 = time % 100;
            timer_text.text = time2.ToString();
            if(time2 > c)
            {
                SceneManager.LoadScene(scene);
                break;
                
            }
        } 
    }
}
