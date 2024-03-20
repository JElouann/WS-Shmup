using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{

    private float meteorspeed = 15f;

    public void FixedUpdate()
    {
        Vector2 position = transform.position;

        position.y -= meteorspeed * Time.deltaTime;

        transform.position = position;
    }
}
