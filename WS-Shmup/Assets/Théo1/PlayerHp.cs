using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    private int hp = 3;


    private void FixedUpdate()
    {

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BulletEnnemy")
        {
            hp--;
            if (hp <= 0)
            {
                Destroy(gameObject);
                Debug.Log("hp");
            }
        }
        if (other.gameObject.tag == "Ennemy")
        {
            hp--;
            if (hp <= 0)
            {
                Destroy(gameObject);
                Debug.Log("hp");
            }
        }
    }
}
