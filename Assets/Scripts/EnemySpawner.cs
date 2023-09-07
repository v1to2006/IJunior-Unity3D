using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private float _spawnDelay = 2;
	[SerializeField] private Transform[] _spawnPoints;
	[SerializeField] private Enemy _enemy;

	private void Start()
	{
		StartCoroutine(SpawnEnemies());
	}

	private IEnumerator SpawnEnemies()
	{
		WaitForSeconds delay = new WaitForSeconds(_spawnDelay);

        while (true)
		{
			Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length - 1)].position, Quaternion.Euler(0, Random.Range(0, 360), 0));

			yield return delay;
		}
	}
}
