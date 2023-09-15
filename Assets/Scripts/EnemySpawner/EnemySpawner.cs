using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private float _spawnDelay = 2;
	[SerializeField] private Transform[] _spawnPoints;

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

			randomSpawnPoint.InstantiateEnemy();

			yield return delay;
		}
	}
}
