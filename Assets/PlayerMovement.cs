using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3.5f; // Movement speed for walking

    void Update()
    {
        // Detect input
        float forwardInput = Input.GetKey("w") ? 1 : Input.GetKey("s") ? -1 : 0;

        // Calculate movement direction
        Vector3 movement = transform.forward * forwardInput * moveSpeed * Time.deltaTime;

        // Move the player
        transform.Translate(movement, Space.World);

        // Optional: Log movement for debugging
        if (forwardInput != 0)
        {
            Debug.Log("Player is moving: " + movement);
        }
    }
}
