using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelHealth : MonoBehaviour
{
    public GameObject Player;
    public GameObject DeadPlayer;
    public float levelHealth = 100;
    public Slider mySlider;
    public Image myImage;
    public Text txt;
    

    private bool isOnDeadZone = false;

   
    void Start()
    {
        Player = gameObject;
        
    }


    void Update()
    {
        txt.text = "+" + Mathf.Floor(levelHealth);

        {
            if (levelHealth <= 0) // ���� �� ������ ��� ����� 0 ������������� ������ ����� � ������� ������ Plazer
            {
                Instantiate(DeadPlayer, Player.transform.position, Player.transform.rotation);
                Destroy(Player);
            }
        }

       /* mySlider.value = levelHealth;// ����������� �������� �������� ��
        if (levelHealth < 1)
        {
            myImage.enabled = false;
        }
        else
        {
            myImage.enabled = true;
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "deadzone")
        {
            isOnDeadZone = true;
            levelHealth = levelHealth - 5 * Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "deadzone")
        {
            levelHealth = levelHealth - 5 * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "deadzone")
        {
            isOnDeadZone = false;
        }
    }
}
