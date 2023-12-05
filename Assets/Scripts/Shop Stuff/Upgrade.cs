using UnityEngine;

public abstract class Upgrade : ScriptableObject {
    public int cost;

    public abstract void Apply();
    public abstract string GetShopMessage();
}