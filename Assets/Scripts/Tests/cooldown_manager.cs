using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class cooldown_manager
{
    // A Test behaves as an ordinary method
    [Test]
    public void cooldown_cannot_fire_immediately()
    {
        PlayerStatistics playerStatistics = new PlayerStatistics();
        playerStatistics.wakeUp();


        PlayerStatistics.instance.projectileCooldownTime = 1f;

        CooldownManager cooldown = new CooldownManager();
        cooldown.resetCooldown();
        Assert.IsFalse(cooldown.canFire());
    }

    [Test]
    public void cooldown_can_fire_after_cooldown_time()
    {
        PlayerStatistics playerStatistics = new PlayerStatistics();
        playerStatistics.wakeUp();


        PlayerStatistics.instance.projectileCooldownTime = 1f;

        CooldownManager cooldown = new CooldownManager();
        cooldown.resetCooldown();
        waitToCheck(cooldown);
        
        
    }
    IEnumerator waitToCheck(CooldownManager cooldown)
    {
        yield return new WaitForSeconds(1);
        Assert.IsTrue(cooldown.canFire());
    }


}
