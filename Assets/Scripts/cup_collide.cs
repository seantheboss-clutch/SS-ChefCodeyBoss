using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup_collide : MonoBehaviour
{
    public GameObject manager;
    public ParticleSystem waterdroplet;
    public GameObject plate;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "drop")
        {
            waterdroplet.Play();
            Invoke("PauseParticle", 3f);
            manager.GetComponent<manager>().two = true;
        }
        if(collision.gameObject.tag == "load")
        {
            this.transform.position = plate.transform.position;
        }
    }
   void PauseParticle()
   {
        waterdroplet.Pause();
   }

}
