using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    public Transform targetPoint;
    public Transform targetPointEND;

    private NavMeshAgent agent;
    private Animator _animator;
    public bool flagGetCoffee = false;
   

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }
    

    void Update()
    {
       
        _animator.SetFloat("Speed",agent.velocity.magnitude);
        
        if (targetPoint != null)
        {
            agent.SetDestination(targetPoint.position);
        }
        if (targetPoint != null&&flagGetCoffee)
        {
            agent.SetDestination(targetPointEND.position);
        }
    }
}
