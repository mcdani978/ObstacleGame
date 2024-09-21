using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;  // Reference to the TextMeshPro component

    // Method to increase or decrease score
    public void IncreaseScore(int amount)
    {
        score += amount;

        // Ensure score does not drop below 0
        if (score < 0)
        {
            score = 0;
        }

        UpdateScoreUI();  // Update the UI when the score changes
    }

    // Method to update the score text
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}