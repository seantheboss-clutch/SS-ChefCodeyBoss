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
    public int n_rrot = -5;
    public int up_counter = 14;
    public bool up_true = true;
    public bool space = false;
    public int x_rot;

    public Rigidbody playerrb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        handCurrent = 1;
        Invoke("Disable", 3f);
    }
    void Disable()
    {
       GetComponent<Animator>().enabled = false;
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
        if (Input.GetKey("right"))
        {
            rotation = Quaternion.Euler(0, rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0,rotation.y, 0);
            //Quaternion r = transform.rotation;
            player.transform.Rotate(rrotation);
            x_rot++;
            //print(r + "         " + transform.rotation);*/
        }
         if (Input.GetKey("left"))
        {
            rotation = Quaternion.Euler(0, -rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y, 0);
            player.transform.Rotate(rrotation);
            x_rot--;
        }
        if (Input.GetKey("space"))
        {
            playerrb.velocity = transform.TransformDirection(Vector3.up * speed/2);
            print(playerrb.velocity.y);
        }

        /*if (Input.GetKey("-") && up_true)
        {
            rotation = Quaternion.Euler(0, 0, rrot);
            rrotation = new Vector3(0, 0, rotation.z);
            player.transform.Rotate(rrotation);
            up_counter--;
            if(up_counter == 0)
            {
                up_true = false;
            }
        }
        if (Input.GetKey("=") && up_true == false)
        {
            rotation = Quaternion.Euler(0, 0, rrot);
            rrotation = new Vector3(0, 0, rotation.z);
            player.transform.Rotate(rrotation);
            up_counter++;
            if (up_counter == 14)
            {
                up_true = true;
            }
        }*/

        //Zeros velocity/rotation
        if (Input.GetKey("0"))
        {
            playerrb.velocity = new Vector3(0, 0, 0);
        }
        else if (Input.GetKey("/"))
        {

            player.transform.Rotate(new Vector3(0, -x_rot, 0));
           
        }
        if (Input.GetKeyDown("l"))
        {
            handCurrent = 0;
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("task"))
        {
            GetComponent<GameManager>().task = true;
        }
    }*/
}