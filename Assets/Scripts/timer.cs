using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float s_p;
    public float t;
    public Text time_before_start;


    void Start()
    {
        s_p = t;
    }
    void Update()
    {
        if(s_p < 1)
        {
            SceneManager.LoadScene("ChefCodey");
        }
        else
        {
            s_p -= .01f;
            time_before_start.text = ": "+Mathf.Floor(s_p).ToString();
        }
    }
}

