using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float liftTimer;
    void Start()
    {
        Destroy(gameObject, liftTimer);
        
    }

    // Update is called once per frame
    
}
