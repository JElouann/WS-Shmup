using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBullet : BulletMain
{
    public SO_Bullet weapon;

    private float bullet_speed;
    private float _lifeTime;

    public Rigidbody2D rigidbody2d;

    private void Start()
    {
        bullet_speed = weapon.bullet_speed;
        damage = weapon.damage;
        _lifeTime = weapon.lifeTime;

        rigidbody2d.AddForce(transform.up * bullet_speed);
        StartCoroutine(DestroyBullet(_lifeTime));
    }

    private void Update()
    {
        if (rigidbody2d.velocity == null)
        {
            rigidbody2d.AddForce(transform.up * bullet_speed);
        }
    }

    private IEnumerator DestroyBullet(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ennemy")
        {
            other.gameObject.SendMessage("LowerHealth", damage, SendMessageOptions.DontRequireReceiver);
        }
        if (other.gameObject.tag == "BulletEnnemy")
        {
            Destroy(other.gameObject);
        }

    }
}