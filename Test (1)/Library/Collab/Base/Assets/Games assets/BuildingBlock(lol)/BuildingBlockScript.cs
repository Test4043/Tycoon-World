using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBlockScript : MonoBehaviour
{
    public float CostOfObject;
    public GameObject[] GameObjectsToApear;
    private void Start()
    {
        for (int i = 0; i <= GameObjectsToApear.Length; i++)
        {
            GameObjectsToApear[i].SetActive(false);
        }
        
        //gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//TODO if player has more money than CostOfObject
        {
            //TODO subtract cost from player
            for (int i = 0; i <= GameObjectsToApear.Length; i++)
            {
                GameObjectsToApear[i].SetActive(true);
            }
        }
    }
}
