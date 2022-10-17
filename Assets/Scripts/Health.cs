using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Health : MonoBehaviour
{
    public float timeRemaining = 10.0f;
    public bool timerIsRunning = true;

    public int curHealth = 0;
    public int maxHealth = 100000; 

    public HealthBar healthBar;

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0 && curHealth > 0)
            {   
                timeRemaining -= Time.fixedDeltaTime;
                if((int) timeRemaining % 2 == 0) {
                    DamagePlayer();
                }
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void DamagePlayer()
    {   
        
        curHealth -= 125000;
        healthBar.SetHealth( curHealth );
    }
}