using UnityEngine;

[CreateAssetMenu]
public class Heal : Upgrade
{
    public int healAmount;

    public override void Apply()
    {
        if (PlayerStatistics.instance.currentMoney >= price)
        {
            PlayerStatistics.instance.changeMoney(-price);
            PlayerStatistics.instance.healHealth(healAmount);
        }
    }

    public override string GetShopMessage()
    {
        return "Heal " + healAmount + " health ($" + price + ")";
    }
}