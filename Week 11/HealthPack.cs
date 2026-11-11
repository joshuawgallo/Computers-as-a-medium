using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 1. Check if the object touching the circle has the PlayerHealth script
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // 2. Try to heal the player
            bool wasHealed = playerHealth.Heal(healAmount);

            // 3. Only destroy the pack if the player wasn't already at 100 health
            if (wasHealed)
            {
                Debug.Log("Health pack collected! Destroying object.");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Player touched the pack but is already at 100 health. Pack remains.");
            }
        }
    }
}
