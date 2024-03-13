using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBullet : MonoBehaviour
{
    public SO_Bullet weapon;


    private float bullet_speed;
    private int damage;
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

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Ennemy")
        {
            other.gameObject.SendMessage("LowerHealth", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
