using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    private void Start()
    {
        Invoke("Loading_scene", 20f);
    }
    void Loading_scene()
    {
        SceneManager.LoadScene("ChefCodey");
    }
}

