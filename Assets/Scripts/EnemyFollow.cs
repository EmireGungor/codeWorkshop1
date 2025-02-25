using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; 
    public float followSpeed = 4f; 

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
    
            transform.position += direction * followSpeed * Time.deltaTime;
        }
    }
}
