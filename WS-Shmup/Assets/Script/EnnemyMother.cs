using TMPro;
using UnityEngine;

public class EnnemyMother : MonoBehaviour
{
    Rigidbody2D rb2D;

    public GameObject MiniEnemy;

    public int _hp = 100;
    public int ScorePoints;

    Score score;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(Vector2.down * 200f);
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    public void LowerHealth(int damage)
    {
        if (_hp > 0)
        {
            _hp -= damage;
            rb2D.AddForce(Vector2.down * 10f);
        }
        if (_hp <= 0)
        {
            Destroy(gameObject);
            score.OnScoreUpdate(ScorePoints);
            Instantiate(MiniEnemy, transform.position, transform.rotation);
        }
    }

}