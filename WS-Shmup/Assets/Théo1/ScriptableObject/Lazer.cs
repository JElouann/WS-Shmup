using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public SO_Bullet weapon;

    private float _lifeTime;
    private float damage;

    public Rigidbody2D rigidbody2d;

    private void Start()
    {
        damage = weapon.damage;
        _lifeTime = weapon.lifeTime;

        StartCoroutine(DestroyBullet(_lifeTime));
    }

    private IEnumerator DestroyBullet(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("LowerHealth", damage, SendMessageOptions.DontRequireReceiver);
    }
}
