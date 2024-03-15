using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Shield : MonoBehaviour
{
    [SerializeField] GameObject shield;

    private void Start()
    {
        shield = GameObject.Find("Shield");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BulletEnnemy")
        {
            shield.SetActive(false);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ennemy")
        {
            shield.SetActive(false) ;
        }
    }
}
