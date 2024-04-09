using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fountain : MonoBehaviour
{
    public bool water_go;
    public GameObject droplet;
    public GameObject spigot_head;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (water_go)
        {
            for(int x = 0; x < 1; x++)
            {
                droplet = Instantiate(droplet, new Vector3(droplet.transform.position.x, droplet.transform.position.y, droplet.transform.position.z), Quaternion.identity);
                
            }
            water_go = false;
        }
    }
}
