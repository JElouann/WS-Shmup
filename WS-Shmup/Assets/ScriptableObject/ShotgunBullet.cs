using System.Collections;
using UnityEngine;

public class ShotgunBullet : BulletMain
{
    public SO_Bullet weapon;


    private float bullet_speed;
    private float cooldown;
    private float _lifeTime;

    public Rigidbody2D rigidbody2d;

    private void Start()
    {
        bullet_speed = weapon.bullet_speed;
        damage = weapon.damage;
        cooldown = weapon.cooldown;
        _lifeTime = weapon.lifeTime;

        rigidbody2d.AddForce(transform.up * bullet_speed);
        StartCoroutine(DestroyBullet(_lifeTime));
    }
    private IEnumerator DestroyBullet(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
