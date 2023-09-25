using UnityEngine;

public class TargetPointMovement : MonoBehaviour
{
	[SerializeField] private Transform _target;
	
	private Transform[] _wayPoints;
	private int _currentPoint = 0;
	private float _speed = 12;


	private void Start()
	{
		_wayPoints = new Transform[transform.childCount];

        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
			_wayPoints[i] = transform.GetChild(i);
        }
    }

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		Transform target = _wayPoints[_currentPoint];

		_target.transform.position = Vector3.MoveTowards(_target.transform.position, target.position, _speed * Time.deltaTime);

		if (_target.transform.position == target.position)
		{
			_currentPoint++;

			if (_currentPoint >= _wayPoints.Length)
			{
				_currentPoint = 0;
			}
		}
	}
}
