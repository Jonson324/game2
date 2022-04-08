using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest_event : MonoBehaviour
{
    public bool quest_ring;
    public GameObject Current_Task;
    public bool quest_ring_end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (quest_ring_end == false) {
            if (quest_ring == true) {
                Current_Task.SetActive(true);
            } else {
                Current_Task.SetActive(false);
            }
        } else {
            Current_Task.SetActive(false);
        }
    }
}
