using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // Assign the enemy prefab in Inspector
    public Transform spawnPoint;    // Assign a spawn location in Inspector

    void Start()
    {
        SpawnEnemy(); // Spawn an enemy when the game starts
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}

