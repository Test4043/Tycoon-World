using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConverbeltScript : MonoBehaviour
{
    public float Speed;
    //public Vector3 direction;
    // Start is called before the first frame update
    private void OnCollisionStay(Collision collision)
    {
        
        collision.gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * Speed;
    }
}
