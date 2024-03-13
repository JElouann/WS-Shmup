using UnityEngine;
using System.Collections;

public class BaseBullet : MonoBehaviour
{
    public SO_Bullet weapon;


    private float bullet_speed;
    private int damage;
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
            other.gameObject.SendMessage("LowerHealth", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
