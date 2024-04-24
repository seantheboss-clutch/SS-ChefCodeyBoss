using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fountain : MonoBehaviour
{
    public bool water_go;
    public GameObject droplet;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (water_go)
        {
            Instantiate(droplet, new Vector3(-0.789f, 0.4961f, 18.751f), Quaternion.identity); ;
            water_go = false;
        }
    }
}
