using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorWarning : MonoBehaviour
{
    public Rigidbody2D warningsprite;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "meteorwarn")
        {
            
        }
    }


}
