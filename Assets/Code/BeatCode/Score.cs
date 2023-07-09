using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int scoreInt;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreInt.ToString();
    }

    public void AddScore(int addScore)
    {
        scoreInt += addScore;
    }
}
