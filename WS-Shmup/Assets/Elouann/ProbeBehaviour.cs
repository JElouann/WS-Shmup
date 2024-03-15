using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ProbeBehaviour : MonoBehaviour
{
    [SerializeField]
    private static List<GameObject> _probes = new();
    public int _health;
    [SerializeField]
    private GameObject _enemyBulletPrefab;
    [SerializeField] private Transform socket;
    [SerializeField] private int _fireForce;

    private void Awake()
    {
        _probes.Add(this.gameObject);
    }

    public void LowerHealth(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
    public void Shooting()
    {
        GameObject _bullet = Instantiate(_enemyBulletPrefab, socket.transform.position, socket.transform.rotation, transform);
        _bullet.GetComponent<Rigidbody2D>().AddForce(-socket.up * _fireForce, ForceMode2D.Impulse);
        Debug.Log(_bullet);
    }
}
