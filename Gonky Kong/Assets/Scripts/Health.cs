using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    // public int playerNumber = 1;

    [SerializeField] int startHealth = 4;

    private int currentHealth;

    private GameManager gameManager;


    // Use this for initialization
    void Start()
    {
        Debug.Log(currentHealth);
        currentHealth = startHealth;
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameManager.PlayerDie();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}  

