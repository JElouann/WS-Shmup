using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.VFX;

[RequireComponent(typeof(VisualEffect))]
public class FireVFXs : MonoBehaviour
{
    private VisualEffect _effect;
    private PlayerInput _input;
    private InputAction _movement;

    private Vector3 _randomVelocityMin;
    private Vector3 _randomVelocityMax;

    private List<Vector3> _newRandomVelocitiesMin = new List<Vector3>() 
    {
        new Vector3(-0.333f, -1, 0), // bottom
        new Vector3(-1, -1, 0), // bottom left
        new Vector3(-1, -0.333f, 0), // left
        new Vector3(-1, 1, 0), // top left
        new Vector3(0.333f, 1, 0), // top
        new Vector3(1, 1, 0), // top right
        new Vector3(1, 0.333f, 0), // right
        new Vector3(1, -1, 0)  // bottom right
    };

    private List<Vector3> _newRandomVelocitiesMax = new List<Vector3>()
    {
        new Vector3(0.333f, -2, 0), // bottom
        new Vector3(-2, -2, 0), // bottom left
        new Vector3(-2, 0.333f, 0), // left
        new Vector3(-2, 2, 0), // top left
        new Vector3(-0.333f, 2, 0), // top
        new Vector3(2, 2, 0), // top right
        new Vector3(2, -0.333f, 0), // right
        new Vector3(2, -2, 0)  // bottom right
    };

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _movement = _input.actions.FindAction("Movement");
        _effect = GetComponent<VisualEffect>();
    }

    public void changeDirection(Vector2 direction)
    { 
        switch (direction)
        {
            case Vector2 _direction when (_direction.y >= -1 && _direction.y < 0): // bottom
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[0]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[0]);
                break;

            case Vector2 _direction when (_direction.x >= -1 && _direction.x < 0) && (_direction.y >= -1 && _direction.y < 0): // bottom left
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[1]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[1]);
                break;

            case Vector2 _direction when (_direction.x >= -1 && _direction.x < 0): // left
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[2]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[2]);
                break;

            case Vector2 _direction when (_direction.x >= -1 && _direction.x < 0) && (_direction.y <= 1 && _direction.y > 0): // top left
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[3]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[3]);
                break;

            case Vector2 _direction when (_direction.y <= 1 && _direction.y > 0): // top
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[4]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[4]);
                break;

            case Vector2 _direction when (_direction.x <= 1 && _direction.x > 0) && (_direction.y <= 1 && _direction.y > 0): // top right
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[5]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[5]);
                break;

            case Vector2 _direction when (_direction.x <= 1 && _direction.x > 0): // right
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[6]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[6]);
                break;

            case Vector2 _direction when (_direction.x <= 1 && _direction.x > 0) && (_direction.y >= -1 && _direction.y < 0): // bottom right
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMin[7]);
                _effect.SetVector3("RandomVelocityMin", _newRandomVelocitiesMax[7]);
                break;
        }
    }
}
