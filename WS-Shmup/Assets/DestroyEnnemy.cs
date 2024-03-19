using UnityEngine;

public class DestroyEnnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ennemy")
        {
            Destroy(other.gameObject);
        }
    }
}
