using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyTemplate;
    [SerializeField] private Transform _targetPoint;

    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(_enemyTemplate, transform.position, Quaternion.identity);
        enemy.SetTargetPoint(_targetPoint);
    }
}
