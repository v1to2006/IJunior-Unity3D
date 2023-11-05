using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float _moveSpeed = 2f;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
