using UnityEngine;

[CreateAssetMenu]
public class DecreaseCooldown : Upgrade {
    public float percentageDecrease;

    public override void Apply() {
        PlayerStatistics.instance.projectileCooldownTime *= percentageDecrease;
    }

    public override string GetShopMessage() {
        return "Decrease cooldown by " + (1f - percentageDecrease) * 100f + "%";
    }
}