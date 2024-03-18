using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileEnemy : MonoBehaviour
{

    public Transform cible;
    private GameObject player;
    private Rigidbody2D missile;
    public GameObject explosion; // VFX explosion
    public float speed = 3f;
    public float rotateSpeed = 200f;

    public void Start()
    {
        missile = GetComponent<Rigidbody2D>();
        player = GameObject.Find("PlayerPrefab");
    }

    private void FixedUpdate()
    {
       // Vector2 direction = (Vector2)cible.position - missile.position;

        Vector2 direction = (Vector2)player.transform.position - missile.position;
        direction.Normalize();

        float valeurRotation = Vector3.Cross(direction, transform.up).z;

        missile.angularVelocity = -valeurRotation * rotateSpeed;

        missile.velocity = transform.up * speed; 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
