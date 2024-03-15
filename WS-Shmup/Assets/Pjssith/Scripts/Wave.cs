using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Wave : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxspawner;

    [SerializeField] private float sRate = 1.0f;

    [SerializeField] private GameObject[] enemiesFab;

    [SerializeField] private bool enableSpawn = true;


    Vector2 cubeCollider;
    Vector2 colliderCenter;

    private void Awake()
    {
        Transform collidertransform = boxspawner.GetComponent<Transform>();
        colliderCenter = collidertransform.position;

        cubeCollider.x = collidertransform.localScale.x * boxspawner.size.x;
        cubeCollider.y = collidertransform.localScale.y * boxspawner.size.y;

    }

    private Vector2 RandomSpawn()
    {
        Vector2 randomPos = new Vector2(Random.Range(-cubeCollider.x / 2, cubeCollider.x / 2), Random.Range(-cubeCollider.y / 2, cubeCollider.y / 2));
        return colliderCenter + randomPos;
    }

    private void Start()
    {
        StartCoroutine(wave());
    }

    private IEnumerator wave()
    {
        WaitForSeconds timeout = new WaitForSeconds(sRate);

            

        while (enableSpawn)
        {
            int random = Random.Range(0, enemiesFab.Length);
            GameObject enemies = enemiesFab[random];
            Instantiate(enemies, RandomSpawn(), Quaternion.identity);
            yield return timeout;
        }
    }


}
