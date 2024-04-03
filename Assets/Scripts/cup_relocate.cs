using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup_relocate : MonoBehaviour
{
    public bool cup_move;
    public GameObject left_hand;
    public Vector3 offset = new Vector3(1f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cup_move)
        {
            this.transform.position = new Vector3(left_hand.transform.position.x+offset.x, left_hand.transform.position.y, left_hand.transform.position.z);
        }
    }
}
