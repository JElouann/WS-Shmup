using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int ScoreP =0;
    private TextMeshProUGUI _scoretext;

    private void Start()
    {
        _scoretext = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    public void OnScoreUpdate(int Points)
    {
        ScoreP += Points;
        _scoretext.text = ScoreP.ToString();
    }
}
