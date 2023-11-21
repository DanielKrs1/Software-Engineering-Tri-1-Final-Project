using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyTemplate : ScriptableObject
{
    public int MaxHealth = 100;
    public int MinReward = 20;
    public int MaxReward = 30;
    public Sprite Sprite;
    public ScriptableObject AttackBehavior;
    public ScriptableObject DeathBehavior;
    public bool RotateRandomly = false;

}