using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public shop scriptShop;
    public string nameItem;
    public int priceItem;
    public Text textItem;
     
    public void buyItem () {
        scriptShop.nameItem = nameItem;
        scriptShop.priceItem = priceItem;

        scriptShop.buyItem();
    }
}
