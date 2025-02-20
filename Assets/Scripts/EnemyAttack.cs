using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header("Enemy Attack Settings")]
    public Transform player; 
    public float followSpeed = 2f; 
    public float attackRange = 1.5f; 
    public float attackCooldown = 1f; 

    private float lastAttackTime;

    void Start()
    {
        lastAttackTime = -attackCooldown; // Initialize last attack time
    }

    void Update()
    {
        FollowPlayer();
        AttackPlayer();
    }

    void FollowPlayer()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += followSpeed * Time.deltaTime * direction;
        }
    }

    void AttackPlayer()
    {
        if (player != null && Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                lastAttackTime = Time.time;
            }
        }
    }
}
