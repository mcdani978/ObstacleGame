using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public int scoreIncrease = 10;  // Amount to increase score
    public int scoreDecrease = 5;   // Amount to decrease score when hit

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";

            // Access the GameManager
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                // Decrease score when the player hits the obstacle
                gameManager.IncreaseScore(-scoreDecrease);  // Decrease score by scoreDecrease
            }
        }
    }
}
