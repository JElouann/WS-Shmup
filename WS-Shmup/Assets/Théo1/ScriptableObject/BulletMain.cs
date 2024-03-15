using UnityEngine;

public class BulletMain : MonoBehaviour
{
    public int damage;

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Ennemy")
        {
            other.gameObject.SendMessage("LowerHealth", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
