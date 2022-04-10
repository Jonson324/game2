using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest_object : MonoBehaviour
{
    public quest_event qe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter (Collider col) {
        if (col.tag == "Player") {
            qe.quest_ring_end = true;
            Destroy(gameObject);
        }
    }
}
