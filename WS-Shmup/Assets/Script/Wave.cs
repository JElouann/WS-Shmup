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

    [SerializeField] private GameObject Boss;

    private int nb_ennemy;
    public int nbennemyspawnboss;

    private bool bossActive = false;


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

    private void FixedUpdate()
    {
        if (nb_ennemy == nbennemyspawnboss)
        {
            if (bossActive == false) 
            { 
                bossActive = true;
                Instantiate(Boss, Vector2.one , Quaternion.identity);
                nbennemyspawnboss += nbennemyspawnboss;
                
            }
            
        }

        if (bossActive == true) 
        {
            GameObject boss = GameObject.Find("Boss(Clone)");
            if (boss == null)
            {
                bossActive = false;
                enableSpawn = true;
                StartCoroutine(wave());
            }
            else
            {
                enableSpawn = false;
            }
        }

    }

    private IEnumerator wave()
    {
        WaitForSeconds timeout = new WaitForSeconds(sRate);


        while (enableSpawn == true)
        {
            int random = Random.Range(0, enemiesFab.Length);
            GameObject enemies = enemiesFab[random];
            Instantiate(enemies, RandomSpawn(), Quaternion.identity);
            yield return timeout;
            nb_ennemy++;
        }
    }


}
