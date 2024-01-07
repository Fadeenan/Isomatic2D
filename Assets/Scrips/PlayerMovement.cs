using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 1.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveH, moveV).normalized * moveSpeed;//OPTIONAL rb.MovePosition();

        Vector2 direction = new Vector2(moveH, moveV);

        FindObjectOfType<PlayerAnimation>().SetDirection(direction);
    }



}
