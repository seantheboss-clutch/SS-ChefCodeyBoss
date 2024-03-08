using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightRotate : MonoBehaviour
{
    public Light d;
    public Quaternion q;
    public Vector3 q2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        q = Quaternion.Euler(0, 180, 0);
        q2 = new Vector3(0, q.y, 0);
        d.transform.Rotate(q2);
    }
}
