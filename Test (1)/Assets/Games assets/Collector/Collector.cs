using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject WhereMoneyGoes;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "drip")
        {
            WhereMoneyGoes.GetComponent<Player>().SaveMoney(collision.gameObject.GetComponent<DroplingVariables>().Cost);
            Destroy(collision.gameObject);
            
        }
    }
}
