using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultBehavior", menuName = "ScriptableObjects/Behaviors/Default", order = 1)]

public class DefaultBehavior : AttackBehavior
{
    public new float Cooldown = 0.5f;
    public override void RepeatedAttack(GameObject me)
    { // Small impulse in random direction
        Rigidbody2D rb = me.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * 100f);
    }
}