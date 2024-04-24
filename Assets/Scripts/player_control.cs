using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public int rrot = 270;
    public int speed = 1;
    public Vector3 rrotation;
    public Quaternion rotation;
    public int x_rot;
    public Rigidbody playerrb;
    public GameObject manager;
    public bool jump;
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
        if (Input.GetKey("right"))
        {
            rotation = Quaternion.Euler(0, rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y, 0);
            //Quaternion r = transform.rotation;
            this.transform.Rotate(rrotation);
            x_rot++;
            //print(r + "         " + transform.rotation);*/
        }
        if (Input.GetKey("left"))
        {
            rotation = Quaternion.Euler(0, -rrot, 0);
            //print(rotation);
            rrotation = new Vector3(0, rotation.y, 0);
            this.transform.Rotate(rrotation);
            x_rot--;
        }
        if (Input.GetKeyDown("up"))
        {
            playerrb.velocity = playerrb.transform.TransformDirection(Vector3.right * speed);
        }
        else if (Input.GetKeyDown("down"))
        {
            playerrb.velocity = playerrb.transform.TransformDirection(Vector3.left * speed);
        }
        if (Input.GetKey("space"))
        {

            if (jump)
            {
                playerrb.velocity = transform.TransformDirection(Vector3.up * speed);
                jump = false;
            }
            //print(playerrb.velocity.y);
        }
        if(Input.GetKey("0"))
        {
            playerrb.velocity = new Vector3(0f, 0f, 0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "water")
        {
            manager.GetComponent<manager>().one = true;
        }
        if (collision.gameObject.tag == "toast")
        {
            manager.GetComponent<manager>().three = true;

        }
        if (collision.gameObject.tag == "ground")
        {
            jump = true;
        }
    }
}
