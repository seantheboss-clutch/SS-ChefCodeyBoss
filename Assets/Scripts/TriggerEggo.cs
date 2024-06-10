using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEggo : MonoBehaviour
{
    public GameObject eggo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other == eggo)
        {
            eggo.GetComponent<eggo_coll>().eggo_bool = true;

        }
    }
}
