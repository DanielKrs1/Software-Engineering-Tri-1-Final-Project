using UnityEngine;

[CreateAssetMenu]
public class MaxHealthIncrease : Upgrade {
    public int healthIncrease;

    public override void Apply() {
        PlayerStatistics.instance.setStartingMaxHealth(PlayerStatistics.instance.maxHealth + healthIncrease);
    }

    public override string GetShopMessage() {
        return "Increase max health by " + healthIncrease;
    }
}