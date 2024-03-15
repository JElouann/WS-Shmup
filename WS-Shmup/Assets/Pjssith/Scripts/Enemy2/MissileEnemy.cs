using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileEnemy : MonoBehaviour
{

    public Transform cible;
    private Rigidbody2D missile;
    public GameObject explosion; // VFX explosion
    public float speed = 3f;
    public float rotateSpeed = 200f;

    public void Start()
    {

        missile = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        Vector2 direction = (Vector2)cible.position - missile.position;

        direction.Normalize();

        float valeurRotation = Vector3.Cross(direction, transform.up).z;

        missile.angularVelocity = -valeurRotation * rotateSpeed;

        missile.velocity = transform.up * speed; 

    }
    void OnTriggerEnter2D() //Modifier pour dégats du missile.
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }

}
