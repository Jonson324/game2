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
    

    private bool isOnDeadZone = false;

   
    void Start()
    {
        Player = gameObject;
        
    }


    void Update()
    {
        {
            if (levelHealth <= 0) // если хп меньше или равно 0 инстанциируем модель трупа и удаляем объект Plazer
            {
                Instantiate(DeadPlayer, Player.transform.position, Player.transform.rotation);
                Destroy(Player);
            }
        }

        mySlider.value = levelHealth;// присваиваем слайдеру значение хп
        if (levelHealth < 1)
        {
            myImage.enabled = false;
        }
        else
        {
            myImage.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "deadzone")
        {
            isOnDeadZone = true;
            levelHealth = levelHealth - 25 * Time.deltaTime;
        }
        //Нанесение урона скелетоми
        if (other.tag == "sword")
        {
            levelHealth = levelHealth - 5;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "deadzone")
        {
            levelHealth = levelHealth - 3 * Time.deltaTime;
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
