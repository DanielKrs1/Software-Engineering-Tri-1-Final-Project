using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultBehavior", menuName = "ScriptableObjects/Behaviors/Default", order = 1)]

public class DefaultBehavior : ScriptableObject
{
    public int cooldown = 100;
    public void OnAttack(GameObject me) { }
    public void OnDeath(GameObject me) { Destroy(me); }

}