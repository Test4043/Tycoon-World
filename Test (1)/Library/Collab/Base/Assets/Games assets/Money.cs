using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float MoneyYouOwn = 0;
    public void ChangeMoney(float Money)
    {
        MoneyYouOwn += Money;
        gameObject.GetComponent<Text>().text = "Money: " + MoneyYouOwn;
    }
}
