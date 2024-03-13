using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    private int _hp = 15;

    public void LowerHealth(int damage)
    {
        if (_hp > 0)
        {
            _hp -= damage;
        } 
        else
        {
            Destroy(gameObject);
        }
    }
}
