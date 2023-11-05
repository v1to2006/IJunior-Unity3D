using UnityEngine;

public class ModifiedCube : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _rotationSpeed;

    private float _scaleUp = 0.1f;

    private void Update()
    {
        MoveForward();
        Rotate();
        Grow();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.down * _rotationSpeed * Time.deltaTime);
    }

    private void Grow()
    {
        transform.localScale += new Vector3(_scaleUp, _scaleUp, _scaleUp) * _scaleSpeed * Time.deltaTime;
    }
}
