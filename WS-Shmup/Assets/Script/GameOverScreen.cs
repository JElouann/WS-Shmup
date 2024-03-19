using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI scoreText;

    private string _finalscore;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = scoreText.text + " POINTS";
    }
}
