using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttacks", menuName = "ScriptableObjects/Behaviors/Default", order = 1)]

public class DefaultAttacks : AttackBehavior
{
    public override void RepeatedAttack(GameObject me)
    { // Add a small velocity
        Rigidbody2D rb = me.GetComponent<Rigidbody2D>();
        rb.velocity += new Vector2(Random.Range(-5f, 0f), Random.Range(-5f, 5f));
    }
}