using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using DG.Tweening;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    [SerializeField]
    private int _health = 10;
    [SerializeField]
    private ProbeBehaviour _bossProbe1;
    [SerializeField]
    private ProbeBehaviour _bossProbe2;
    [SerializeField]
    private ProbeBehaviour _bossProbe3;
    [SerializeField]
    private ProbeBehaviour _bossProbe4;

    private GameObject _rotator;

    private Rigidbody2D _rb;

    private GameObject _barrier;

    private bool _isBarrierOn = true;
    private bool _canShoot;

    [SerializeField]
    private float _probeSpeed;

    [SerializeField]
    private GameObject _enemyBulletPrefab;
    [SerializeField]
    private Transform socket;

    private void Awake()
    {
        _rotator = this.transform.GetChild(0).gameObject;
        _rb = GetComponent<Rigidbody2D>();
        _barrier = transform.GetChild(1).gameObject;
    }

    private void Start()
    {
        print(_rotator);
        StartCoroutine(RotatingProbes());
        StartCoroutine(MovingBoss());
        StartCoroutine(Shooting());
    }

    public void LowerHealth(int damage)
    {
        if (!_isBarrierOn)
        {
            _health -= damage;
            if (_health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void Update()
    {
        if(_bossProbe1 == null && _bossProbe2 == null && _bossProbe3 == null && _bossProbe4 == null)
        {
            _isBarrierOn = false;
            Destroy(_barrier);
        }

        if (_bossProbe1 == null && _bossProbe2 == null && _bossProbe3 == null && _bossProbe4 == null)
        {
            _canShoot = false;
        }
    }

    private IEnumerator RotatingProbes()
    { 
        while (_health>0)
        {
            _rotator.transform.Rotate(0, 0, _probeSpeed);
            yield return null;
        }
    }

    private IEnumerator MovingBoss()
    {
        _rb.AddForce(new Vector2(-70, 0));
        yield return new WaitForSeconds(1.2f);
        do
        {
            _rb.velocity = Vector2.zero;
            _rb.AddForce(new Vector2(140, 0));
            yield return new WaitForSeconds(1.2f);
            _rb.AddForce(new Vector2(-140, 0));
            _rb.velocity = Vector2.zero;
            yield return new WaitForSeconds(1.2f);
        } while (_health>0);
    }

    private IEnumerator Shooting()
    {
        while (_health>0)
        {
            if (!_canShoot)
            {
                _bossProbe1.Shooting();
                _bossProbe2.Shooting();
                _bossProbe3.Shooting();
                _bossProbe4.Shooting();
                yield return new WaitForSeconds(1);
            }
        }
    }
}
