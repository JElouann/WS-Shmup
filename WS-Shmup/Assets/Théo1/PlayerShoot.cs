using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    PlayerInput _input;

    InputAction _shoot;

    private bool _PlayerOnShoot = false;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _shoot = _input.actions.FindAction("Shoot");
    }

    private void FixedUpdate()
    {
        if (_PlayerOnShoot == true)
        {
            _PlayerOnShoot=false;
            Debug.Log("Tu tires");
        }
    }

    void OnShoot()
    {
        _PlayerOnShoot = true;
    }
}
