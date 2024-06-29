using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public int rrot = 270;
    public int speed = 2;
    public Vector3 rrotation;
    public Quaternion rotation;
    public int x_rot;
    public Rigidbody playerrb;
    public GameObject manager;
    public bool jump;
    public GameObject eggo;
    public GameObject hand;
    public bool t_coll;
    public GameObject e;
    public Renderer e_coll_r;
    public bool c_coll;
    public GameObject cup;
    public GameObject toaster_touch_object;
    public int displacement = 2;
    public bool t_d;
    // Start is called before the first frame update
    void Start()
    {
        //wake.Play("wake_up");
        Invoke("Disable", 3f);

    }

    void Disable()
    {
        this.GetComponent<Animator>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rotation = Quaternion.Euler(0, rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y, 0);
            //Quaternion r = transform.rotation;
            this.transform.Rotate(rrotation);
            x_rot++;
            //print(r + "         " + transform.rotation);*/
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            rotation = Quaternion.Euler(0, -rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y, 0);
            this.transform.Rotate(rrotation);
            x_rot--;
        }
        if (Input.GetKeyDown("up") || Input.GetKey("w"))
        {
            playerrb.velocity = playerrb.transform.TransformDirection(Vector3.right * speed);
        }
        else if (Input.GetKeyDown("down") || Input.GetKey("s"))
        {
            playerrb.velocity = playerrb.transform.TransformDirection(Vector3.left * speed);
        }
        if (Input.GetKey("space"))
        {

            if (jump)
            {
                playerrb.velocity = transform.TransformDirection(Vector3.up * (speed+1));
                jump = false;
            }
            //print(playerrb.velocity.y);
        }
        if (Input.GetKey("0"))
        {
            playerrb.velocity = new Vector3(0f, 0f, 0f);
        }
        if (Physics.Raycast(this.transform.position, Vector3.forward, 10f))
        {
            print("Bonk");
            print("");
        }
        if (t_coll)
        {
            if (c_coll)
            {
                levitation(eggo,displacement+1);
            }
            else if(t_d)
            {
                levitation(eggo, displacement);
            }
        }
        if (c_coll)
        {
            levitation(cup,displacement);
        }
    }
    private void levitation(GameObject t,int d)
    {
        t.transform.position = new Vector3(hand.transform.position.x-.25f, hand.transform.position.y + d, hand.transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "water")
       {
            manager.GetComponent<manager>().one = true;
            c_coll = true;
       }
       if (collision.gameObject.tag == "end")
       {
            manager.GetComponent<manager>().end = true;
       }
       if(collision.gameObject.tag == "toast")
       {
            t_coll = true;
       }
       if(collision.gameObject.tag == "plate")
        {
            c_coll = false;
            cup.GetComponent<cup_collide>().can_drop_cup = true;
        }

       if (Physics.Raycast(this.transform.position, Vector3.down, 5f) || collision.gameObject.tag == "ground")
       {
           jump = true;
       }
        if (collision.gameObject.tag == "load" && t_coll)
        {
            manager.GetComponent<manager>().three = true;
            e_coll_r.material.SetColor("_Color",Color.black);
        }

    }
}
