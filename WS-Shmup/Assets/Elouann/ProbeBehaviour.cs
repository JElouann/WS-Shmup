using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeBehaviour : MonoBehaviour
{
    [SerializeField]
    private static List<GameObject> _probes = new();
    public int _health;

    private void Awake()
    {
        _probes.Add(this.gameObject);
    }

    private void Start()
    {
       
    }

    public void LowerHealth(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
