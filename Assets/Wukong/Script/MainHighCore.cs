using UnityEngine;
using UnityEngine.UI;

public class MainHighCore : MonoBehaviour
{
    public Text highScoreText;

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Score: " + highScore.ToString("0000000");
    }
}
