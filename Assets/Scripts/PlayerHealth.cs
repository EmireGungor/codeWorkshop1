using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    [System.Obsolete]
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player health: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    [System.Obsolete]
    void Die()
    {
        Debug.Log("Player died");
        DestroyObject(gameObject);
      
    }
}
