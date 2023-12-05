using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GuidedMissile", menuName = "ScriptableObjects/Behaviors/Missile", order = 1)]

public class GuidedMissile : AttackBehavior
{
    public override void ChargedAttack(GameObject me)
    {
        // Very fast velocity towards player
        Vector3 dist = GameObject.FindWithTag("Player").transform.position - me.transform.position;
        me.GetComponent<Rigidbody2D>().velocity = new Vector2(dist.x, dist.y).normalized * 5f;
    }
    public override void RepeatedAttack(GameObject me)
    { // Continue to pursue player
        Vector3 dist = GameObject.FindWithTag("Player").transform.position - me.transform.position;
        me.GetComponent<Rigidbody2D>().velocity *= 0.8f;
        me.GetComponent<Rigidbody2D>().velocity += new Vector2(dist.x, dist.y).normalized;
    }
}