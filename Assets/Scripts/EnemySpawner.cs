using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTimer = 10f;
    public Vector2 spawnRangeX = new(-10f, 10f);
    public float spawnY = 0f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnTimer);
    }

    private void SpawnEnemy()
    {
        float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
        Vector3 spawnPosition = new(randomX, spawnY, 0f);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
