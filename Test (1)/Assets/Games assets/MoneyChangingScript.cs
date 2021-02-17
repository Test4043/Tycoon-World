using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyChangingScript : MonoBehaviour
{
    public void ChangeMoney(float Money)
    {
        gameObject.GetComponent<Text>().text = "Money: " + Money;
    }
}
