using System.Collections;
using System.Collections.Generic;
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

    [SerializeField] Collider2D _colliderDetected;

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

    private void Update()
    {
        if (gameObject.transform.rotation.y == 45)
        {
            Shooting();
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ShootDetection")
        {
            Shooting();
        }
    }

    public void Shooting()
    {
        GameObject _bullet = Instantiate(_enemyBulletPrefab, socket.transform.position, socket.transform.rotation, null);
        _bullet.GetComponent<Rigidbody2D>().AddRelativeForce(-socket.up * _fireForce, ForceMode2D.Impulse);
    }
}
