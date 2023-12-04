using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour

{
    // Start is called before the first frame update
    public static PlayerStatistics instance { get; private set; }
    public int maxHealth { get; private set; }
    public int currentHealth { get; private set; }
    public int currentMoney { get; private set; }

    public float projectileCooldownTime { get; set; }


    void Awake()
    {
        projectileCooldownTime = 0.75f;
        maxHealth = 100;
        currentHealth = maxHealth;
        currentMoney = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeHealth(int additionalHealth)
    {
        currentHealth += additionalHealth;
        
    }

    void loseHealth(int healthLost)
    {
        changeHealth(-healthLost);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    void changeMoney(int additionalMoney)
    {
        currentHealth += additionalMoney;

    }

    

}
