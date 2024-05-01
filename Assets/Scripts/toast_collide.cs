using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toast_collide : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "toast")
        {
            manager.GetComponent<manager>().three = true;
        }
    }
}
