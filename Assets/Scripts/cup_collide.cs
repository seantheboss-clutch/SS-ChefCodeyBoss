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
        if(collision.gameObject.tag == "load")
        {
            this.transform.position = new Vector3(-8.8f,-5.1f,57.1f);
        }
    }
}
