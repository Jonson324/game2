using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task : MonoBehaviour
{
    public bool EndDialog;
    public GameObject dialog1;
    public GameObject dialog1_end;
    public GameObject LevelHealth;
    public quest_event quest_event;
    public GameObject Hint;
    public GameObject shop;
    public bool fin_dialog;
    public bool dialog1_end_disable;
    public bool ring_obtained;

    // Update is called once per frame
    void Update()
    {
        if (EndDialog == true) {
            Time.timeScale = 1;
            dialog1.SetActive(false);
            LevelHealth.SetActive(true);
            quest_event.quest_ring = true;
        }
        if (fin_dialog == true) {
            Time.timeScale = 1;
            quest_event.quest_ring = false;
            dialog1_end.SetActive(false);
            LevelHealth.SetActive(true);
            dialog1_end_disable = true;
            fin_dialog = false;
        }
    }

    void OnTriggerEnter (Collider col) {
        if (col.tag == "Player") {
            Hint.SetActive(true);
        }
    }

    void OnTriggerStay (Collider col) {
        if (Input.GetKey(KeyCode.E)) {
            Time.timeScale = 0; //pause
            Hint.SetActive(false);
            LevelHealth.SetActive(false);
            if (ring_obtained == false) {
                dialog1.SetActive(true);
            } else {
                if (dialog1_end_disable == false) {
                    Time.timeScale = 0; //pause 
                    dialog1_end.SetActive(true);
                } else {
                    Time.timeScale = 0; //pause 
                    shop.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
    }

    void OnTriggerExit (Collider col) {
        Hint.SetActive(false);
    }
}
