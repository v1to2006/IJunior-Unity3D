using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private float _spawnInterval = 2;
	[SerializeField] private Transform[] _spawnPoints;
	[SerializeField] private GameObject _objectToSpawn;

	private void Start()
	{
		StartCoroutine(SpawnEnemies());
	}

	private IEnumerator SpawnEnemies()
	{
		while (true)
		{
			Instantiate(_objectToSpawn, _spawnPoints[Random.Range(0, _spawnPoints.Length - 1)].position, Quaternion.Euler(0, Random.Range(0, 360), 0));

			Debug.Log($"{_objectToSpawn.name} spawned");

			yield return new WaitForSeconds(_spawnInterval);
		}
	}
}
