using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catapult : MonoBehaviour
{
    public GameObject eggo;
    public Rigidbody e_rig;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //e_rig.useGravity = false;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

       /* e_rig.useGravity = true;
        while (eggo.transform.position)
        {
            StartCoroutine(One());
            StartCoroutine(Two());
        }*/
    }
    IEnumerator One()
    {
        e_rig.AddForce(Vector3.up * 10);
        yield return null;
    }
    IEnumerator Two()
    {
        e_rig.AddForce(Vector3.forward * 10);
        yield return null;
    }
}
