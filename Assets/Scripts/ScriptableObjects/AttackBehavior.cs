using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AttackBehavior", menuName = "ScriptableObjects/Behavior", order = 1)]

public abstract class AttackBehavior : ScriptableObject
{
    public float Cooldown;
    public virtual void RepeatedAttack(GameObject me) {}
    public float ChargeTime;
    public virtual void ChargedAttack(GameObject me) {}
}