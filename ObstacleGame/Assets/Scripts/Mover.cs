using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpHeight = 2f; // Height to which the player will jump
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        JumpPlayer(); // Check for jump input
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASO or arrow keys");
        Debug.Log("Press Space to jump");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }

    void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            StartCoroutine(Jump());
        }
    }

    IEnumerator Jump()
    {
        isJumping = true;
        float jumpSpeed = 5f;
        float elapsedTime = 0f;
        float duration = 0.5f; // Duration of the jump

        Vector3 startPosition = transform.position;
        Vector3 targetPosition = startPosition + Vector3.up * jumpHeight;

        // Move up
        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, (elapsedTime / duration));
            elapsedTime += Time.deltaTime * jumpSpeed;
            yield return null;
        }

        elapsedTime = 0f;

        // Move down
        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(targetPosition, startPosition, (elapsedTime / duration));
            elapsedTime += Time.deltaTime * jumpSpeed;
            yield return null;
        }

        transform.position = startPosition; // Ensure the player ends up at the current position
        isJumping = false;
    }
}
