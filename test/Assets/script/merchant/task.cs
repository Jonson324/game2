using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task : MonoBehaviour
{
    public bool EndDialog;
    public GameObject dialog1;
    public GameObject dialog1_end;
    public GameObject LevelHealth;
    public quest_event qe;
    public bool fin_dialog;

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
            qe.quest_ring = true;
        }
        if (fin_dialog == true) {
            Time.timeScale = 1;
            qe.quest_ring = false;
            dialog1.SetActive(false);
        }
    }
    void OnTriggerEnter (Collider col) {
        if (col.tag == "Player") {
            Time.timeScale = 0; //pause
            if (qe.quest_ring_end == false) {
                dialog1.SetActive(true);
                LevelHealth.SetActive(false);
            } else {
                dialog1_end.SetActive(true);
            }
        }
    }
}
