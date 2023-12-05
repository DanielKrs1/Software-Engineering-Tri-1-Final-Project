using UnityEngine;

public abstract class Upgrade : ScriptableObject {
    public abstract void Apply();
    public abstract string GetShopMessage();

    public int price;
}