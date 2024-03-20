using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Ennemy : MonoBehaviour
{
    public int _hp = 100;
    public int ScorePoints;
    [SerializeField] private Color _damageColor;

    Score score;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    public virtual void LowerHealth(int damage)
    {
        if (_hp > 0)
        {
            _hp -= damage;
            StartCoroutine(DamageAnimation());
        }
        if (_hp <= 0)
        {
            StartCoroutine(DamageAnimation());
            Destroy(gameObject);
            score.OnScoreUpdate(ScorePoints);
        }
    }

    private IEnumerator DamageAnimation()
    {
        this.gameObject.GetComponent<SpriteRenderer>().DOColor(_damageColor, 0.1f);
        yield return new WaitForSeconds(0.1f);
        this.gameObject.GetComponent<SpriteRenderer>().DOColor(new Color(100, 100, 100, 100), 0.1f);
    }
}