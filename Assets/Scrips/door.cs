using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject doorOb;
    public GameObject Player;
    public bool isKey = false;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(isKey == true)
        {
            doorOb.GetComponent<Renderer>().enabled = false;
            doorOb.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

}
