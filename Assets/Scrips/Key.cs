using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject doorOb;
    public GameObject key;
    public GameObject Player;
    public GameObject block;
    public bool isKey = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("key"))
        {
            Debug.Log("key picked up");
            key.SetActive(false);
            isKey = true;

            
        }
        if(col.CompareTag("door"))
        {
            if (isKey == true)
            {
                Debug.Log("door Opened");
                doorOb.GetComponent<Renderer>().enabled = false;
                doorOb.GetComponent<BoxCollider2D>().enabled = false;
                block.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
