using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public int speed = 1;
    public int handCurrent = 1;
    public Vector3 rrotation;
    public Quaternion rotation;
    public int rrot = 270;
    public int lrot = -90;
    public Rigidbody playerrb;
    public Rigidbody rhandrb;
    public Rigidbody lhandrb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        handCurrent = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if(Input.GetKeyDown("up"))
        {
            playerrb.velocity = transform.TransformDirection(Vector3.right * speed);
        } else if(Input.GetKeyDown("down"))
        {
            playerrb.velocity = transform.TransformDirection(Vector3.left * speed);
        }
        //Rotation
        if(Input.GetKey("right"))
        {
            rotation = Quaternion.Euler(0, rrot, 0);
            rrotation = new Vector3(0, rotation.y, 0);
            player.transform.Rotate(rrotation);
        }else if(Input.GetKey("left"))
        {
            rotation = Quaternion.Euler(0, lrot, 0);
            rrotation = new Vector3(0, rotation.y, 0);
            player.transform.Rotate(rrotation);
        }
        //Zeros velocity
        if(Input.GetKey("0"))
        {
            playerrb.velocity = new Vector3(0,0,0);
        }
        //moves hands
        if (Input.GetKeyDown("8"))
        {
            if(handCurrent == 0)
            {
                lhandrb.velocity = transform.TransformDirection(Vector3.right * speed);
            } else
            {
                rhandrb.velocity = transform.TransformDirection(Vector3.right * speed);
            }
        } 
        if (Input.GetKeyDown("2"))
        {
            playerrb.velocity = transform.TransformDirection(Vector3.down * speed);
        }
        if(Input.GetKeyDown("l"))
        {
            handCurrent = 0;
        }
    }
}
