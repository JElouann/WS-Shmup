using UnityEngine;

public class Shield : MonoBehaviour
{
    private GameObject _shield;

    private void Start()
    {
        _shield = GameObject.Find("Shield");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BulletEnnemy")
        {
            _shield.SetActive(false);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ennemy")
        {
            _shield.SetActive(false) ;
        }
    }
}
