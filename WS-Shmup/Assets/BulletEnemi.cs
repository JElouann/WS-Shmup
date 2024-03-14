using System.Collections;
using UnityEngine;

public class BulletEnemi : MonoBehaviour
{
    [SerializeField]
    private float _lifeTime;

    void Start()
    {
        StartCoroutine(DestroyBullet(_lifeTime));
    }
    
    private IEnumerator DestroyBullet(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
