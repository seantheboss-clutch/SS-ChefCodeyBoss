using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool task;
    public GameObject[] object_list;
    public GameObject left_hand;
    public GameObject squirt;
    public int count_task = 1;
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
            count_task++;
            switch (count_task)
            {
                case 1:
                    left_hand.GetComponent<cup_relocate>().cup_move = true;
                    //count_task++;
                    task_count.text = count_task.ToString();
                    print("GET YOUR BUSINESS DONE!");
                    break;
                case 2:
                   squirt.GetComponent<fountain>().water_go = true;
                    //count_task++;
                    break;
                default:
                    print("HUmpfh");
                    break;



            }
            //Invoke("Disable",3f);
        }
    }
    void Disable()
    {
        task = false;
    }
}
