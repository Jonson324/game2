using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task : MonoBehaviour
{
    public bool EndDialog;
    public GameObject dialog1;
    public GameObject LevelHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EndDialog == true) {
            Time.timeScale = 1;
            dialog1.SetActive(false);
            LevelHealth.SetActive(true);
        }
    }
    void OnTriggerEnter (Collider col) {
        if (col.tag == "Player") {
            Time.timeScale = 0; //pause
            dialog1.SetActive(true);
            LevelHealth.SetActive(false);
        }
    }
}
