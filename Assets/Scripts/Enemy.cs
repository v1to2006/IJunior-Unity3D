using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private float _movementSpeed = 3;

	private Transform _target;

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		transform.Translate(_target.position * _movementSpeed * Time.deltaTime);
	}

	public void SetTargetPoint(Transform targetPoint)
	{
		_target = targetPoint;
	}
}
