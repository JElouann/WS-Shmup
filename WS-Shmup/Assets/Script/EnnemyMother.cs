using System.Collections;
using DG.Tweening;
using UnityEngine;

public class EnnemyMother : MonoBehaviour
{
    Rigidbody2D rb2D;

    public GameObject MiniEnemy;

    public int _hp = 100;
    public int ScorePoints;

    Score score;

    [SerializeField] private Color _damageColor;
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
            StartCoroutine(DamageAnimation());
        }
        if (_hp <= 0)
        {
            StartCoroutine(DamageAnimation());
            Destroy(gameObject);
            score.OnScoreUpdate(ScorePoints);
            Instantiate(MiniEnemy, transform.position, transform.rotation);
        }
    }
    private IEnumerator DamageAnimation()
    {
        this.gameObject.GetComponent<SpriteRenderer>().DOColor(_damageColor, 0.1f);
        yield return new WaitForSeconds(0.1f);
        this.gameObject.GetComponent<SpriteRenderer>().DOColor(new Color(100, 100, 100, 100), 0.1f);
    }
}