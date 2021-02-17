using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBlockScript : MonoBehaviour
{
    public float CostOfObject;
    public GameObject[] GameObjectsToApear;
    public GameObject WhereMoneyGoes;
    private void Start()
    {
        for (int i = 0; i < GameObjectsToApear.Length; i++)
        {
            GameObjectsToApear[i].SetActive(false);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && WhereMoneyGoes.GetComponent<Player>().MoneyPlayerHas >= CostOfObject)
        {
            WhereMoneyGoes.GetComponent<Player>().SaveMoney(-CostOfObject);
            for (int i = 0; i < GameObjectsToApear.Length; i++)
            {
                GameObjectsToApear[i].SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
