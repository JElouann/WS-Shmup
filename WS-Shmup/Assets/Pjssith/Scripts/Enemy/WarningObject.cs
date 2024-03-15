using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningObject : MonoBehaviour
{
    public Rigidbody2D warningsprite;
    public enemymove warningspeed;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "spritedetect")
        {
            /* warningsprite.transform.position*/
            Debug.Log("Trigger");
        }
    }



    
}
