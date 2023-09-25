using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        const string Horizontal = "Horizontal";
        const string Vertical = "Vertical";

        float moveHorizontal = Input.GetAxis(Horizontal);
        float moveVertical = Input.GetAxis(Vertical);

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.position += movement * _speed * Time.deltaTime;
    }
}
