using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup_collide : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "drop")
        {
            manager.GetComponent<manager>().two = true;
        }
    }
}
