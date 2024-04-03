using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_collide : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject cup;
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        print(collision);
        if (collision.gameObject.tag == "task")
        {
            //GetComponent<GameManager>().task = true;
            cup.GetComponent<cup_relocate>().cup_move = true;
            //Debug.Log(GetComponent<cup_relocate>().cup_move);
        }
    }
}
