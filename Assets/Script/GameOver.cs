using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public TMP_Text finalScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = PlayerPrefs.GetInt("ScoreAkhir", 0);
        finalScore.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
