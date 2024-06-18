using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup_collide : MonoBehaviour
{
    public GameObject manager;
    public ParticleSystem waterdroplet;
    public GameObject plate;
    public GameObject toaster_touch_object;
    public Renderer cup_renderer;
    public GameObject e;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "drop")
        {
            waterdroplet.Play();
            Invoke("PauseParticle", 3f);
            manager.GetComponent<manager>().two = true;
            cup_renderer.material.SetColor("_Color",Color.blue);
        }
        if(collision.gameObject.tag == "load")
        {
            this.transform.position = plate.transform.position;
        }
        if(collision.gameObject == toaster_touch_object)
        {
            manager.GetComponent<manager>().three = true;
            e.GetComponent<eggo_coll>().eggo_bool = true;
        }
    }
   void PauseParticle()
   {
        waterdroplet.Pause();
   }

}
