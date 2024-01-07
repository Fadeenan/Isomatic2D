using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnamyController : MonoBehaviour
{
    private Animator anim;
    public Vector3 dir;
    public Transform waypoint1, waypoint2;
    private Transform waypointTarget;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float attackRange;
    private SpriteRenderer sp;
    private Transform target; 

   
    // Start is called before the first frame update
    void Start()
    {
        waypointTarget = waypoint1;
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) >= attackRange)//PlayerOutside attackrange
        {
            Patrol();
        }
        else
        {
            
        }


    }

    private void Patrol()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypointTarget.position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoint1.position) <= 0.01f)
        {
            waypointTarget = waypoint2;
            sp.flipX = false;
            Animate();
        }
        if (Vector2.Distance(transform.position, waypoint2.position) <= 0.01f)
        {
            waypointTarget = waypoint1;
            sp.flipX = true;
            Animate();
        }
    }

    void Animate()
    {
        anim.SetFloat("AnimMoveX", dir.x);
        anim.SetFloat("AnimMoveY", dir.y);
        anim.SetFloat("AnimMoveMagnitude", dir.magnitude);
    }

}


