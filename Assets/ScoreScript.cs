using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript Instance;
    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Debug.Log("ScoreManager started");
        UpdateUI();
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText == null)
        {
            Debug.LogError("ScoreText is NOT assigned!");
            return;
        }

        scoreText.text = $"Coins: {score}";
    }
}
