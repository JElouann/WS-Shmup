using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int _hp = 100;
    public int ScorePoints;

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
        }
        if (_hp <= 0)
        {
            Destroy(gameObject);
            score.OnScoreUpdate(ScorePoints);
        }
    }
}