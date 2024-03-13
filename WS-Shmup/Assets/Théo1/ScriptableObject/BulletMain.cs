using UnityEngine;

public class BulletMain : MonoBehaviour
{
    public int damage;

    public virtual void OnCollisionEnter2D(Collision2D other)
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
