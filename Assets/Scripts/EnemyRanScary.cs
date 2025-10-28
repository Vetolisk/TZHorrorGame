using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyRanScary : MonoBehaviour
{

    private NavMeshAgent agent;
    private Animator _animator;


     public Transform targetPoint;          // ссылка на игрока
    public float attackCooldown = 1f; // интервал между атаками
    public float chaseRadius = 100;        // радиус преследования
    public float attackRadius = 1f;        // радиус атаки
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
            // Враг видит игрок: движется к нему
            agent.SetDestination(targetPoint.position);
        //}
        /*else
        {
            // Враг не видит игрок, останавливается
            agent.ResetPath();
        }*/

        if (distance <= attackRadius)
        {
            // Враг в радиусе атаки
            StartCoroutine(AttackRoutine());
        }

    }
    
    IEnumerator AttackRoutine()
    {
        isAttacking = true;
        _animator.SetBool("Atack",true);
        agent.isStopped=true;
        agent.speed = 0;
        // Время выполнения атаки. Можно добавить анимацию здесь
        yield return new WaitForSeconds(1); // задержка перед нанесением урона или эффектом атаки

        // Тут выполняем урон/эффект
        Debug.Log("Враг нанес урон!");

        // После атаки ждем cooldown
        yield return new WaitForSeconds(attackCooldown);
        _animator.SetBool("Atack", false);
        agent.isStopped = false;
        agent.speed = 3.5f;
        Debug.Log("Атака завершена");
        isAttacking = false;
    }
}

