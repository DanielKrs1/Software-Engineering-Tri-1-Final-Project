using UnityEngine;

[CreateAssetMenu]
public class DecreaseCooldown : Upgrade
{
    public float percentageDecrease;

    public override void Apply()
    {
        if (PlayerStatistics.instance.currentMoney >= price)
        {
            PlayerStatistics.instance.changeMoney(-price);
            PlayerStatistics.instance.projectileCooldownTime *= percentageDecrease;
        }
    }

    public override string GetShopMessage()
    {
        return "Decrease cooldown by " + (1f - percentageDecrease) * 100f + "% ($" + price + ")";
    }
}