using System.Collections;
using UnityEngine;

public class RocketBullet : MonoBehaviour
{

    private int _damage = 100;
    private float _lifeTime = 0.75f;

    private void Start()
    {
        StartCoroutine(DestroyBullet(_lifeTime));
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ennemy")
        {
            other.gameObject.SendMessage("LowerHealth", _damage, SendMessageOptions.DontRequireReceiver);
        }
    }

    private IEnumerator DestroyBullet(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
