using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public static event Action OnHandDestroy;
    public GameObject gameWinScreen;

    [SerializeField] HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
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
        GameObject.Find("full-hand").SetActive(false);
        OnHandDestroy?.Invoke();
    }

    private void OnEnable()
    {
        HandHealth.OnHandDestroy += EnableWinScreen;
    }

    private void OnDisable()
    {
        HandHealth.OnHandDestroy -= EnableWinScreen;

    }

    public void EnableWinScreen()
    {
        gameWinScreen.SetActive(true);
    }
}
