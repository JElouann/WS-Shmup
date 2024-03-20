using UnityEngine;

public class SpecialAbilty : MonoBehaviour
{
    [SerializeField] private GameObject BulletSpecial;
    [SerializeField] private Transform sockect;

    Score score;
    private int losepoints = -750;

    private int Points;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
        Points = score.ScoreP;
    }

    private void OnSpecialAbility()
    {
        Points = score.ScoreP;
        Points += losepoints;

        if (Points < 0){}

        else if (Points >= 0)
        {
            score.OnScoreUpdate(losepoints);
            Instantiate(BulletSpecial, sockect.position, transform.rotation);
        }
    }
}
