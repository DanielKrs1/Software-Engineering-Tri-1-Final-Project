using UnityEngine;

[CreateAssetMenu]
public class MaxHealthIncrease : Upgrade {
    public int healthIncrease;

    public override void Apply() {
        Debug.Log("I added " + healthIncrease + " health!");
    }

    public override string GetShopMessage() {
        return "Increase max health by " + healthIncrease;
    }
}