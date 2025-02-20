using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed = 5f;
    [SerializeField] float xLimit = 10f;

    private int direction = 1;

    void Update()
    {
        Vector3 movement = new Vector2(enemySpeed, transform.position.y);
        transform.Translate(direction * Time.deltaTime * movement);

        if (transform.position.x >= xLimit)
        {
            direction = -1;
        }
        else if (transform.position.x <= -xLimit)
        {
            direction = 1;
        }
    }
}



    