using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform Player; // Reference to the player
    public Vector3 offset = new Vector3(0, 0, 0); // Offset from the player
    public float smoothSpeed = 0.125f; // Smoothing factor for camera movement

    void LateUpdate()
    {
        // Target position for the camera
        Vector3 desiredPosition = Player.position + offset;

        // Smoothly move the camera to the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;

        // Optional: Make the camera look at the player
        transform.LookAt(Player);
    }
}
