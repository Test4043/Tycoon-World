using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBlocks : MonoBehaviour
{
    public float MultiplacationAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "drip")
        {
            other.gameObject.GetComponent<DroplingVariables>().Cost *= MultiplacationAmount;
        }
    }
}
