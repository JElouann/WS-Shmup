using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletlifetime : MonoBehaviour
{

    private float lifetime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletlife());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator bulletlife()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(this.gameObject);
    }
  

}
