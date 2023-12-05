using UnityEngine;

[CreateAssetMenu]
public class IncreaseDamage : Upgrade
{
    public int damageIncrease;

    public override void Apply()
    {
        if (PlayerStatistics.instance.currentMoney >= price)
        {
            PlayerStatistics.instance.changeMoney(-price);
            PlayerStatistics.instance.projectileDamage += damageIncrease;
        }
    }

    public override string GetShopMessage()
    {
        return "Increase damage by " + damageIncrease + " ($" + price + ")";
    }
}