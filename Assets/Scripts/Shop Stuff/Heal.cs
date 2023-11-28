using UnityEngine;

[CreateAssetMenu]
public class Heal : Upgrade {
    public int healAmount;

    public override void Apply() {
        Debug.Log("Healing player by " + healAmount + " health!");
    }

    public override string GetShopMessage() {
        return "Heal " + healAmount + " health";
    }
}