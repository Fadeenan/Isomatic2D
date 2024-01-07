using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Enemy : MonoBehaviour
{
    private Animator anim;
    public Vector3 dir;
    [SerializeField] Transform target;

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        dir = target.position - transform.position;
        Animate();
        dir.Normalize();
    }
    void Animate()
    {
        anim.SetFloat("AnimMoveX", dir.x);
        anim.SetFloat("AnimMoveY", dir.y);
        anim.SetFloat("AnimMoveMagnitude", dir.magnitude);
    }
}
