using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    [SerializeField] HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar = GetComponentInChildren<HealthBar>();
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        if (healthBar.slider.value <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    

}
