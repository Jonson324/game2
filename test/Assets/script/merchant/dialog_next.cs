using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog_next : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    private bool isText = true;
    public task npc_taskScript;
	public bool fin_dialog;
		
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown (0)) {
				if (isText == true) {
					isText = false;
				} else {
					if (fin_dialog == false) {
						isText = true;
						npc_taskScript.EndDialog = true;
					} else {
						isText = true;
						npc_taskScript.fin_dialog = true;
					}
				}
			}
		if (isText == true) {
			Text1.SetActive (true);
			Text2.SetActive (false);
		} else {
			Text1.SetActive (false);
			Text2.SetActive (true);
		}
  	}
}
