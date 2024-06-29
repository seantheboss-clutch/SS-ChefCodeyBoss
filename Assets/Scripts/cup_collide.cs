using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup_collide : MonoBehaviour
{
    public GameObject manager;
    public ParticleSystem waterdroplet;
    public GameObject plate;
    public Renderer cup_renderer;
    public bool can_drop_cup;
    public GameObject player;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "drop")
        {
            waterdroplet.Play();
            manager.GetComponent<manager>().two = true;
            cup_renderer.material.SetColor("_Color",Color.blue);
        }
    }
    void Update()
    {
        if(can_drop_cup)
        {
            this.transform.position = new Vector3(plate.transform.position.x - 10, plate.transform.position.y, plate.transform.position.z);
            if(player.GetComponent<player_control>().t_coll)
            {
                player.GetComponent<player_control>().t_d = true;
            }    
        }
    }

}
