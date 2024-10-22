using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth; // Public variable to set player's health in the inspector

    private int currentHealth; // Current health of the player

    // Start is called before the first frame update
    void Start()
    {
        // Set player's health to the maximum at the start
        currentHealth = maxHealth;
    }

    // Function to deal damage to the player
    public void TakeDamage(int damageAmount)
    {
        // Reduce current health by damage amount
        currentHealth -= damageAmount;

        Debug.Log("Enemy took damage. Current Health: " + currentHealth);

        // Check if the player health has reached zero or below
        if (currentHealth <= 0)
        {
            Die(); // Call the Die function if health is 0 or less
        }
    }

    // Function to handle player death
    private void Die()
    {
        Debug.Log("Enemy died.");

        // Destory the enemy
        Destroy(gameObject);
    }
}