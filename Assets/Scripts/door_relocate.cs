using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_relocate : MonoBehaviour
{
    public bool open_door;
    public Vector3 start_position = new Vector3(0, 0, -14.1f);
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = start_position;
    }
        // Update is called once per frame
    void Update()
    {
        if (open_door)
        {
           this.transform.position = new Vector3(start_position.x, start_position.y, 14.3f);
        }
    }
}