using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_light : MonoBehaviour
{
    private Quaternion d_r_rotation;
    void Update()
    {
        d_r_rotation = Quaternion.Euler(50f,-30f,0f);
        this.transform.rotation = d_r_rotation;
    }
}
