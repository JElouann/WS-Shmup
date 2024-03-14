using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    [SerializeField]
    private int _health = 10;
    [SerializeField]
    private GameObject _bossProbe1;
    [SerializeField]
    private GameObject _bossProbe2;
    [SerializeField]
    private GameObject _bossProbe3;
    [SerializeField]
    private GameObject _bossProbe4;

    private GameObject _rotator;

    private Rigidbody2D _rb;

    [SerializeField]
    private float _probeSpeed;

    private void Awake()
    {
        _rotator = this.transform.GetChild(0).gameObject;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        print(_rotator);
        StartCoroutine(RotatingProbes());
        StartCoroutine(MovingBoss());
    }

    public void LowerHealth(int damage)
    {
        if(_health <= damage)
        {
            Destroy(this);
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
}
