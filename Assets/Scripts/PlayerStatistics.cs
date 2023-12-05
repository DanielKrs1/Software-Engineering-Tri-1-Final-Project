using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour

{
    // Start is called before the first frame update

    public static PlayerStatistics instance { get; private set; }
    public int maxHealth { get; private set; }
    public int currentHealth { get; private set; }
    public int currentMoney { get; private set; }

    public float projectileCooldownTime { get; set; }
    public int projectileDamage { get; set; }

    public int levelNumber { get; set; }


    protected void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        projectileCooldownTime = 0.5f;
        projectileDamage = 20;
        maxHealth = 100;
        currentHealth = maxHealth;
        currentMoney = 5;
        levelNumber = 1;
        if (Application.isPlaying)
            DontDestroyOnLoad(gameObject);
    }

    public void wakeUp()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void changeHealth(int additionalHealth)
    {
        currentHealth += additionalHealth;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }

    }
    public void healHealth(int healthHealed)
    {
        changeHealth(healthHealed);
    }

    public void setStartingHealth(int startingHealth)
    {

        currentHealth = startingHealth;
    }
    public void setStartingMaxHealth(int startingHealth)
    {
        maxHealth = startingHealth;

    }
    public void loseHealth(int healthLost)
    {
        changeHealth(-healthLost);
        if (currentHealth <= 0)
        {
            currentHealth = 0;

        }
    }

    public void changeMoney(int additionalMoney)
    {
        currentMoney += additionalMoney;

    }

    public void nextLevel()
    {
        levelNumber++;

    }

}
