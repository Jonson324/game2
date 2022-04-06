using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ticking_damage : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GetComponent<LevelHealth>().levelHealth -= 1 * Time.deltaTime;
        }
    }

    
}
