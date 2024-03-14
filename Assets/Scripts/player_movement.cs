using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public int speed = 1;
    public int handCurrent = 1;
    private Vector3 rrotation;
    private Quaternion rotation;
    public int rrot = 5;
    public int n_rrot = -270;
    public int lrot = -90;
    public Rigidbody playerrb;
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
        if (Input.GetKeyDown("up"))
        {
            playerrb.velocity = transform.TransformDirection(Vector3.right * speed);
        }
        else if (Input.GetKeyDown("down"))
        {
            playerrb.velocity = transform.TransformDirection(Vector3.left * speed);
        }
        //Rotation
        if (Input.GetKeyDown("right"))
        {
            rotation = Quaternion.Euler(0, rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y*100, 0);
            Quaternion r = transform.rotation;
            player.transform.Rotate(rrotation);
            print(r + "         " + transform.rotation);
        }
        else if (Input.GetKey("left"))
        {
            rotation = Quaternion.Euler(0, -rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y*100, 0);
            player.transform.Rotate(rrotation);
        }

        if (Input.GetKey("-"))
        {
            rotation = Quaternion.Euler(0, 0, rrot);
            rrotation = new Vector3(0, 0, rotation.z);
            player.transform.Rotate(rrotation);
        }
        
        //Zeros velocity/rotation
        if (Input.GetKey("0"))
        {
            playerrb.velocity = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey("*"))
        {

            //moves hands
            if (Input.GetKeyDown("l"))
            {
                handCurrent = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "door")
        {
            player.GetComponent<GameManager>().door_move = true;
        }
    }
}