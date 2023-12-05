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

    public int levelNumber { get; private set; }


    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
        projectileCooldownTime = 0.5f;
        projectileDamage = 10;
        maxHealth = 100;
        currentHealth = maxHealth;
        currentMoney = 5;
        levelNumber = 1;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void changeHealth(int additionalHealth)
    {
        currentHealth += additionalHealth;

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
