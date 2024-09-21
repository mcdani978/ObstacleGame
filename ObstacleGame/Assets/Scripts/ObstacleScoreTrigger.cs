using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScoreTrigger : MonoBehaviour
{
    public int scoreIncrease = 10;  // Amount to increase the score
    public float detectionDelay = 2.0f;  // Time to wait before increasing score

    private bool playerInside = false;  // To track if the player is inside the trigger
    private float timer = 0f;  // To track the time the player has been in the trigger

    // Trigger event when player enters the detection zone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInside = true;  // Player has entered the trigger zone
        }
    }

    // Trigger event when player exits the detection zone
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInside = false;  // Player has exited the trigger zone
            timer = 0f;  // Reset the timer when player leaves
        }
    }

    private void Update()
    {
        // If the player is inside the trigger zone
        if (playerInside)
        {
            timer += Time.deltaTime;  // Increase timer as long as player is in the zone

            // If player has been in the zone for at least the detection delay (2 seconds)
            if (timer >= detectionDelay)
            {
                // Access the GameManager and increase the score
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {
                    gameManager.IncreaseScore(scoreIncrease);
                }

                // Reset the timer and prevent multiple score increases for the same trigger
                playerInside = false;
                timer = 0f;
            }
        }
    }
}
