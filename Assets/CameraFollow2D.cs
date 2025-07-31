using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [SerializeField] private Transform player; // Player reference
    [SerializeField] private float smoothSpeed = 0.125f; // Smoothing factor
    [SerializeField] private Vector3 offset = new Vector3(0, 0, -10); // Offset from the player

    void LateUpdate()
    {
        if (player == null) return;

        // Target position with offset
        Vector3 targetPosition = player.position + offset;

        // Smoothly move camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}