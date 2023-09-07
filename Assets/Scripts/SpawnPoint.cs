using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _targetPoint;

    public void InstantiateEnemy()
    {
        Instantiate(_enemy, transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));
        _enemy.GetComponent<Enemy>().SetTargetPoint(_targetPoint);
    }
}
