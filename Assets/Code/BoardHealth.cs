using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }



}

