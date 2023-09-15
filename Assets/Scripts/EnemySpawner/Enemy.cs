using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private float _movementSpeed = 3;

	private Transform _target;

	public void SetTargetPoint(Transform targetPoint)
	{
		_target = targetPoint;
	}

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		transform.position = Vector3.MoveTowards(transform.position, _target.position, _movementSpeed * Time.deltaTime);
	}
}
