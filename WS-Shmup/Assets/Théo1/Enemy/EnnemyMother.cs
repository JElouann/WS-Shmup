using UnityEngine;

public class EnnemyMother : Ennemy
{
    Rigidbody2D rb2D;

    [SerializeField] GameObject MiniEnemy;



    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(Vector2.down * 200f);
    }

    public override void LowerHealth(int damage)
    {
        if (_hp > 0)
        {
            _hp -= damage;
        }
        if (_hp <= 0)
        {
            Instantiate(MiniEnemy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
