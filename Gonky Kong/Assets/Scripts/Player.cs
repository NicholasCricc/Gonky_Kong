using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar healthBar;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Damage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void Damage()
    {
        currentHealth--;

        if (currentHealth <= 0)
        {
            if (gameObject.tag == "Player" && gameManager != null) gameManager.PlayerDie();
            Die();

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
