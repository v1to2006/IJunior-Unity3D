using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private float _scaleUp = 0.1f;

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        transform.localScale += new Vector3(_scaleUp, _scaleUp, _scaleUp) * _scaleSpeed * Time.deltaTime;
    }
}
