using UnityEngine;

[CreateAssetMenu]
public class Heal : Upgrade {
    public int healAmount;

    public override void Apply() {
        PlayerStatistics.instance.healHealth(healAmount);
    }

    public override string GetShopMessage() {
        return "Heal " + healAmount + " health";
    }
}