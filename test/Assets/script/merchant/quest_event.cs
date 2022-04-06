using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest_event : MonoBehaviour
{
    public bool quest_ring;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (quest_ring == true) {
            Text.SetActive(true);
        } else {
            Text.SetActive(false);
        }
    }
}
