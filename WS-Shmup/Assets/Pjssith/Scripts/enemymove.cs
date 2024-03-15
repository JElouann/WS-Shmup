using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{

    public float enemyspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
      Vector2 position = transform.position;

        position.y -= enemyspeed * Time.deltaTime;

        transform.position = position;
    }
}
