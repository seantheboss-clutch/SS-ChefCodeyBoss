using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool door_move;
    public GameObject[] object_list;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(door_move)
        {
            object_list[0].transform.Translate(Vector3.up * 100);
        }
    }
}
