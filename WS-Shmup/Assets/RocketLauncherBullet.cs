using System.Collections;
using UnityEngine;

public class RocketLauncherBullet : MonoBehaviour
{
    public SO_Bullet weapon;


    private float bullet_speed;
    private int damage;
    private float _lifeTime;
    public float _cooldown;

    public Rigidbody2D rigidbody2d;

    public GameObject Explosion;

    private void Awake()
    {
        bullet_speed = weapon.bullet_speed;
        damage = weapon.damage;
        _lifeTime = weapon.lifeTime;
        _cooldown = weapon.cooldown;

        rigidbody2d.AddForce(transform.up * bullet_speed);
        StartCoroutine(DestroyBullet(_lifeTime));
    }

    private IEnumerator DestroyBullet(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    public virtual void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            var b = gameObject.transform.position;
            Instantiate(Explosion, b , transform.rotation);
        }

        if (other.gameObject.tag == "Ennemy")
        {
            var b = gameObject.transform.position;
            Instantiate(Explosion, b, transform.rotation);
            Destroy(gameObject);
        }
    }
}
