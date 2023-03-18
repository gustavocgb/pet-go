using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxHealth : MonoBehaviour
{

    public float maxHealth = 600f;
    public float currentHealth;

    public HealthBar healthBar;
    // Start is called before the first frame update
    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);
    }

    // Update is called once per frame
    public void Update()
    {
        TakeDamage(0.02f);
    }

    public void TakeDamage(float damage)
    {
        currentHealth = healthBar.getHealth();
        currentHealth -= damage;

        healthBar.setHealth(currentHealth);
    }

    public float returnHealth()
    {
        return currentHealth;
    }
}
