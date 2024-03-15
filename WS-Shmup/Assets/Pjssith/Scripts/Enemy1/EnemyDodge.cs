using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDodge : MonoBehaviour
{
    private float amp = 6f;
    private float fre = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 position = transform.position;

        float sin = Mathf.Sin(position.y * fre ) * amp;
        position.x = sin;

        transform.position = position;
    }
}
