using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyTemplate;
    [SerializeField] private Transform _targetPoint;

    public void InstantiateEnemy()
    {
        Instantiate(_enemyTemplate, transform.position, Quaternion.identity);
        _enemyTemplate.SetTargetPoint(_targetPoint.position);
    }
}
