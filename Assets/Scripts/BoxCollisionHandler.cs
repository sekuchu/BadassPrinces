using UnityEngine;

public class BoxCollisionHandler : MonoBehaviour
{
    public Transform teleportTarget; // Reference to the teleport target position

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PressurePlate"))
        {
            // Teleport the box to the teleport target position
            transform.position = teleportTarget.position;
        }
    }
}