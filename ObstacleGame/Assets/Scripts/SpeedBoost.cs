using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpeedBoost : MonoBehaviour
{
    public float speedIncrease = 2f; 
    public float duration = 5f; 

    private void OnTriggerEnter(Collider other)
    {
        Mover player = other.GetComponent<Mover>();
        if (player != null)
        {
            Debug.Log("Speed boost collected!"); 
            player.ApplySpeedBoost(speedIncrease, duration);
            Destroy(gameObject); 
        }
        else
        {
            Debug.Log("Collision detected with: " + other.name); 
        }
    }
}