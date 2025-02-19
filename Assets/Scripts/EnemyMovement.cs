using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 5f;
    public Rigidbody2D rb;
    public Transform leftBoundary; // Left boundary point
    public Transform rightBoundary; // Right boundary point

    private bool movingRight = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (movingRight)
        {
            rb.linearVelocity = new Vector2(enemySpeed, rb.linearVelocity.y);
            if (transform.position.x >= rightBoundary.position.x)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            rb.linearVelocity = new Vector2(-enemySpeed, rb.linearVelocity.y);
            if (transform.position.x <= leftBoundary.position.x)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
