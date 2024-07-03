using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float t;
    void Start()
    {
        Invoke("Loading_scene", t);
    }
    void Loading_scene()
    {
        SceneManager.LoadScene("ChefCodey");
    }
}

