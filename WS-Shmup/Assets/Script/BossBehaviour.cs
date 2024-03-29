using System.Collections;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    [Header ("Stats")]
    [SerializeField] private int _health = 10;
    [SerializeField] private float _probeSpeed;
    [SerializeField] private int _fireForce;

    [Header ("Minions")]
    [SerializeField] private ProbeBehaviour _bossProbe1;
    [SerializeField] private ProbeBehaviour _bossProbe2;
    [SerializeField] private ProbeBehaviour _bossProbe3;
    [SerializeField] private ProbeBehaviour _bossProbe4;

    [Header("System")]
    [SerializeField] private Transform socket;
    [SerializeField] private GameObject _enemyBulletPrefab;
    [SerializeField] private Color _damageColor;
    private GameObject _rotator;
    private Rigidbody2D _rb;
    private GameObject _barrier;
    private bool _isBarrierOn = true;
    private bool _shoot = true;

    [Header("Heal")]
    [SerializeField] private GameObject Heal;

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
    }

    public void LowerHealth(int damage)
    {
        if (!_isBarrierOn)
        {
            _health -= damage;
            StartCoroutine(DamageAnimation());
            if (_health <= 0)
            {
                Destroy(this.gameObject);
                Instantiate(Heal, Vector3.zero, Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        if(_bossProbe1 == null && _bossProbe2 == null && _bossProbe3 == null && _bossProbe4 == null)
        {
            _isBarrierOn = false;
            Destroy(_barrier);
            if (_shoot)
            {
                Shoot();

            }
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

    private async void Shoot()
    {
        _shoot = false;
        GameObject _bullet = Instantiate(_enemyBulletPrefab, socket.transform.position, socket.transform.rotation, null);
        _bullet.GetComponent<Rigidbody2D>().AddForce(-socket.up * _fireForce, ForceMode2D.Impulse);
        await Task.Delay(500);
        _shoot = true;

    }

    private IEnumerator DamageAnimation()
    {
        this.gameObject.GetComponent<SpriteRenderer>().DOColor(_damageColor, 0.1f);
        yield return new WaitForSeconds(0.1f);
        this.gameObject.GetComponent<SpriteRenderer>().DOColor(new Color(100, 100, 100, 100), 0.1f);
    }
}
