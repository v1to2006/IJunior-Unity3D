using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.down * _rotationSpeed * Time.deltaTime);
    }
}
