using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{ 
    public TextMeshProUGUI scoreText;

    private string _finalscore;

    void Start()
    {
        if (scoreText == null)
        {
            scoreText = GetComponent<TextMeshProUGUI>();
        }
        _finalscore = scoreText.text;
    }
    public void UpdatePointsFinaux()
    {
        _finalscore = scoreText.text;
    }
}