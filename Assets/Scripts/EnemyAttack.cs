using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header("Enemy Attack Settings")]
    public Transform player;
    public float attackRange = 1.5f;
    public float attackCooldown = 1f;

    private float lastAttackTime;

    void Start()
    {
        lastAttackTime = -attackCooldown;
    }

    void Update()
    {
        AttackPlayer();
    }

    void AttackPlayer()
    {
        if (player != null && Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(10);
                }

                lastAttackTime = Time.time;
            }
        }
    }
}

/* First code;
 
  using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header("Enemy Attack Settings")]
    public Transform player;
    public float attackRange = 1.5f;

    void Update()
    {
        AttackPlayer();
    }

    void AttackPlayer()
    {
        if (player != null && Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);
            }
        }
    }
}

 */