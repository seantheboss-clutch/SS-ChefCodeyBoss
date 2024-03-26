using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool task;
    public GameObject[] object_list;
    public GameObject player;
    public int count_task = 0;
    public Text task_count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(task)
        {
            switch (count_task)
            {
                case 1:
                    GetComponent<cup_relocate>().cup_move = true;
                    count_task++;
                    task_count.text = count_task.ToString();
                    break;
                case 2:
                    GetComponent<fountain>().water_go = true;
                    count_task++;
                    break;
                default:
                    print("HUmpfh");
                    break;



            } object_list[0].transform.position = player.transform.position;
            //Invoke("Disable",3f);
        }
    }
    void Disable()
    {
        task = false;
    }
}
