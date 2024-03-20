using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteor;
    public BoxCollider2D meteorspawner;
    public BoxCollider2D meteorwarn;

    Vector2 cubeCollider;
    Vector2 colliderCenter;

    private void Awake()
    {
        Transform collidertransform = meteorspawner.GetComponent<Transform>();
        colliderCenter = collidertransform.position; 

        cubeCollider.x = collidertransform.localScale.x * meteorspawner.size.x;
        cubeCollider.y = collidertransform.localScale.y * meteorspawner.size.y;

    }

    private void Start()
    {
        StartCoroutine(meteorshower());
    }

    private Vector2 RandomMeteor()
    {
        Vector2 randomPos = new Vector2(Random.Range(-cubeCollider.x / 2, cubeCollider.x / 2), Random.Range(-cubeCollider.y / 2, cubeCollider.y / 2));
        return colliderCenter + randomPos;
    }

    public IEnumerator meteorshower()
    {
        while (true)
        {
            GameObject meteorstatane = Instantiate(meteor, RandomMeteor(), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }

    /*
    void Start()
    {
        StartCoroutine(MeteorEvent());
    }

    void Update()
    {
        Vector2 randomPos = transform.position + Random.insideUnitCircle * boxColliderSize;

    }

    
    public IEnumerator MeteorEvent()
    {
        GameObject _meteor = Instantiate(meteor, meteorspawner.position, meteorspawner.rotation);
        _meteor.GetComponent<Rigidbody2D>().AddForce(-meteorspawner.up * meteorspeed, ForceMode2D.Impulse);
        yield return new WaitForSeconds(3f);


     
    }*/


}
