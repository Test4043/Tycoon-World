using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroplingVariables : MonoBehaviour
{
    public float Cost;
    private int timer = 1000;
    private void FixedUpdate()
    {
        timer -= 1;
        if(timer<= 0)
        {
            Destroy(gameObject);
        }
    }
}
