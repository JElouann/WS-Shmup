using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    PlayerInput _input;

    InputAction _movement;

    private float speed = 5.0f;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _movement = _input.actions.FindAction("Movement");
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 direction = _movement.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * speed;
    }
}
