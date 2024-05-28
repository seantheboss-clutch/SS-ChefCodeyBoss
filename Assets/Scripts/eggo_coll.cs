using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggo_coll : MonoBehaviour
{
    public Renderer e_coll_r;
    public bool eggo_bool;
    private void Start()
    {
        eggo_bool = false;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "toast" && eggo_bool)
        {
            StartCoroutine("ColorChange");
        }
    }
    void ColorChange()
    {
        e_coll_r.material.SetColor("_Color", Color.black);
    }

}
