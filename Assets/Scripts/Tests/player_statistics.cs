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
        
        PlayerStatistics playerStatistics = new PlayerStatistics();


        int intialHealth = PlayerStatistics.instance.currentHealth;
        PlayerStatistics.instance.loseHealth(1);
        Assert.AreEqual(intialHealth-1, PlayerStatistics.instance.currentHealth);
    }

}
