using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth= 100;
    public int currentHealth;
    public Health_Bar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth=maxHealth;
        //healthBar.SetMaxHealth(maxHealth);

    }

    void TakeDamage(int damage)
        {
            currentHealth-=damage;
            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Die();
            }
        }
        
        void Die()
        {
            Debug.Log("Player died.");
        }

    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                TakeDamage(20);
            }
            
        }
}
