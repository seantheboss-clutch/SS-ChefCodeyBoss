using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fountain : MonoBehaviour
{
    public bool water_go;
    public GameObject droplet;
    public GameObject spigot_head;
    public Text task_count; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (water_go)
        {
            for (int x = 0; x < 500; x++)
            {
                Instantiate(droplet, spigot_head.transform.position, Quaternion.identity);
            }
        }
    }
}
