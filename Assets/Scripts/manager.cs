using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public int speed = 1;
    public Vector3 rrotation;
    public Quaternion rotation;
    public int rrot = 270;
    public bool up_true = true;
    public bool space = false;
    public int x_rot;
    public GameObject squirt;
    public Vector3 fount_pos = new Vector3(-69.63f,-41.25f,6.47f);
    public Rigidbody playerrb;
    public GameObject player;
    public GameObject cup;
    public Text one_t;
    public Text two_t;
    public Text three_t;
    public bool boo;
    public bool one = false;
    public bool two = false;
    public bool three = false;
    public GameObject droplet;

    // Start is called before the first frame update
    void Start()
    {
        cup.GetComponent<BoxCollider>().enabled = true;
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
            rrotation = new Vector3(0, rotation.y, 0);
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
            playerrb.velocity = transform.TransformDirection(Vector3.up * speed / 2);
            print(playerrb.velocity.y);
        }

        if (Input.GetKey("0"))
        {
            playerrb.velocity = new Vector3(0, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "water")
        {
            one_t.text = "True";
        }
        if (collision.gameObject.tag == "drop")
        {
            two_t.text = "True";
        }
        if(collision.gameObject.tag == "key")
        {
            Instantiate(droplet, new Vector3(droplet.transform.position.x, droplet.transform.position.y, droplet.transform.position.z), Quaternion.identity);
        }
        if (collision.gameObject.tag == "toast")
        {
            three_t.text = "True";
        }
    }
}