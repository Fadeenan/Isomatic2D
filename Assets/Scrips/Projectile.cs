using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float moveSpeed;
    private float liftTimer;
    [SerializeField] private float maxLife = 2.0f;

    public GameObject attackEffect;
    public GameObject destroyEffect;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        liftTimer += Time.deltaTime;
        if(liftTimer > maxLife)
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player") 
        { 
            Instantiate(attackEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
