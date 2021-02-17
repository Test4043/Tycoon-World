using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject Dropling;
    public float Value;
    public float Size;
    public float Time;
    private float Timer;
    private GameObject DroplingDup;
    private void Start()
    {
        Timer = Time;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if(Timer <= 0)
        {

            MakeItem();
            Timer = Time;
        }
        else
        {
            Timer -= 1;
        }
    }
    public void MakeItem()
    {
        DroplingDup = Instantiate(Dropling);
        DroplingDup.transform.position = gameObject.transform.position;
        DroplingDup.transform.localScale = new Vector3(Size,Size,Size);
        DroplingDup.GetComponent<DroplingVariables>().Cost = Value;
    }
}
