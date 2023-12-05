using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class player_statistics
{
    // A Test behaves as an ordinary method
    [Test]
    public void health_drops_by_health_lost()
    {
        GameObject testStatsHandler = new GameObject("Handler");
        PlayerStatistics playerStatistics = testStatsHandler.AddComponent<PlayerStatistics>();
        playerStatistics.wakeUp();

        PlayerStatistics.instance.setStartingMaxHealth(5);
        PlayerStatistics.instance.setStartingHealth(5);

        int intialHealth = PlayerStatistics.instance.currentHealth;
        PlayerStatistics.instance.loseHealth(1);
        Assert.AreEqual(intialHealth-1, PlayerStatistics.instance.currentHealth);
    }

    [Test]
    public void health_does_not_drop_below_0()
    {

        PlayerStatistics playerStatistics = new PlayerStatistics();
        playerStatistics.wakeUp();

        PlayerStatistics.instance.setStartingHealth(5);

       
        PlayerStatistics.instance.loseHealth(100);
        Assert.AreEqual(0, PlayerStatistics.instance.currentHealth);
    }


    [Test]
    public void health_does_not_exceed_max_health()
    {

        PlayerStatistics playerStatistics = new PlayerStatistics();
        playerStatistics.wakeUp();

        PlayerStatistics.instance.setStartingMaxHealth(10);
        PlayerStatistics.instance.setStartingHealth(5);


        PlayerStatistics.instance.healHealth(100);
        Assert.AreEqual(10, PlayerStatistics.instance.currentHealth);
    }
}
