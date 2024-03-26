using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] private float spawnRange = 5f;
    [SerializeField] private int maxEnemies = 6;
    private float _nextSpawnTime;
    private Health _health;

    void Start()
    {
        _nextSpawnTime = Time.time + spawnRate;
        _health = GetComponent<Health>();
    }
    
    void Update()
    {
        if (Time.time >= _nextSpawnTime && CountEnemies() < maxEnemies)
        {
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRange;
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            _nextSpawnTime = Time.time + spawnRate;
        }
    }
    
    private int CountEnemies()
    {
        var enemyCount = 0;

        Collider[] colliders = Physics.OverlapSphere(transform.position, spawnRange);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                enemyCount++;
            }
        }

        return enemyCount;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Cat"))
        {
            _health.TakeDamage(1);
        }
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, spawnRange);
    }
}
