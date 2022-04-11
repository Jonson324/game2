using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog_next : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject dialog1_end;
	public GameObject Ring;
    private bool next;
    public task taskScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
			if (next == false) {
				next = true;
				if (taskScript.ring_obtained == true) {
					taskScript.fin_dialog = true;
				}
			} else {
				next = false;
				if (taskScript.ring_obtained == false) {
					Ring.SetActive(true);
					taskScript.EndDialog = true;
				}
			}
		}
		
		if (next == false) {
			Text1.SetActive (true);
			Text2.SetActive (false);
		} else {
			Text1.SetActive (false);
			Text2.SetActive (true);
		}
	}
}
