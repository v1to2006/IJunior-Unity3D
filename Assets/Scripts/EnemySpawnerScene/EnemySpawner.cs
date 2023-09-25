using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private SpawnPoint[] _spawnPoints;
	[SerializeField] private float _spawnDelay = 2;

	private void Start()
	{
		StartCoroutine(SpawnEnemies());
	}

	private IEnumerator SpawnEnemies()
	{
		WaitForSeconds delay = new WaitForSeconds(_spawnDelay);

        while (true)
		{
			SpawnPoint randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length - 1)].GetComponent<SpawnPoint>();

			randomSpawnPoint.SpawnEnemy();

			yield return delay;
		}
	}
}
