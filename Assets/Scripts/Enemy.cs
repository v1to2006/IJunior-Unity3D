using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private float _movementSpeed = 3;

	private Vector3 _target = Vector3.zero;

	public void SetTargetPoint(Vector3 targetPoint)
	{
		_target = targetPoint;
	}

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		Vector3 direction = (_target - transform.position).normalized;
		transform.Translate(direction * _movementSpeed * Time.deltaTime);
		Debug.Log(_target);
	}
}
