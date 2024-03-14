using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    public Transform firesocket;
    public GameObject bullet;
    public float fireforce;
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartFiring());;
    }

    // Update is called once per frame
    void Update()
    {   
        
    }


    // Enemy starts firing at spawn, forever, bullet speed = fireforce
    public IEnumerator StartFiring()
    {
        while(true)
        {
            GameObject _bullet = Instantiate(bullet, firesocket.transform.position, firesocket.transform.rotation);
            _bullet.GetComponent<Rigidbody2D>().AddForce(-firesocket.up * fireforce, ForceMode2D.Impulse);

            yield return new WaitForSeconds(1);
        }
        
    }

}
