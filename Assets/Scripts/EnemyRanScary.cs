using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyRanScary : MonoBehaviour
{

    private NavMeshAgent agent;
    private Animator _animator;


     public Transform targetPoint;          // ������ �� ������
    public float attackCooldown = 1f; // �������� ����� �������
    public float chaseRadius = 100;        // ������ �������������
    public float attackRadius = 1f;        // ������ �����
    private bool isAttacking = false;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        
        _animator.SetFloat("Speed", agent.velocity.magnitude);
        float distance = Vector3.Distance(transform.position, targetPoint.position);

        //if (distance <= chaseRadius)
        //{
            // ���� ����� �����: �������� � ����
            agent.SetDestination(targetPoint.position);
        //}
        /*else
        {
            // ���� �� ����� �����, ���������������
            agent.ResetPath();
        }*/

        if (distance <= attackRadius)
        {
            // ���� � ������� �����
            StartCoroutine(AttackRoutine());
        }

    }
    
    IEnumerator AttackRoutine()
    {
        isAttacking = true;
        _animator.SetBool("Atack",true);
        agent.isStopped=true;
        agent.speed = 0;
        // ����� ���������� �����. ����� �������� �������� �����
        yield return new WaitForSeconds(1); // �������� ����� ���������� ����� ��� �������� �����

        // ��� ��������� ����/������
        Debug.Log("���� ����� ����!");

        // ����� ����� ���� cooldown
        yield return new WaitForSeconds(attackCooldown);
        _animator.SetBool("Atack", false);
        agent.isStopped = false;
        agent.speed = 3.5f;
        Debug.Log("����� ���������");
        isAttacking = false;
    }
}

