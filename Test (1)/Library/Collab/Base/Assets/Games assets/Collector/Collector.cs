using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public float Cost = 0;
    public GameObject MoneyWords;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "drip")
        {
            MoneyWords.GetComponent<Money>().ChangeMoney(collision.gameObject.GetComponent<DroplingVariables>().Cost);
            Destroy(collision.gameObject);
            
        }
    }
}
