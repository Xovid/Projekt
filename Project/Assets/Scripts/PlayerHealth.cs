using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrnetHealth;


    private void Start()
    {
        playerCurrnetHealth = playerMaxHealth;
    }

    void TakeDamage(int amount)
    {
        playerCurrnetHealth -= amount;

        if(playerCurrnetHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}



