using UnityEngine;

[CreateAssetMenu]
public class IncreaseDamage : Upgrade {
    public int damageIncrease;

    public override void Apply() {
        PlayerStatistics.instance.projectileDamage += damageIncrease;
    }

    public override string GetShopMessage() {
        return "Increase damage by " + damageIncrease;
    }
}