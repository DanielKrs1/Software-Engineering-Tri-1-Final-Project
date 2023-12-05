using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyTemplate EnemyData;
    public AttackBehavior Attacks;
    private SpriteRenderer _spriteRenderer;
    public int Health { get; set; }

    GameObject sprite;

    // Start is called before the first frame update
    void Start()
    {
        // Make sprite
        sprite = new GameObject("Sprite");
        sprite.transform.SetParent(transform);
        sprite.transform.position = transform.position;
        sprite.transform.localScale = new Vector3(1f, 1f, 1f);
        _spriteRenderer = sprite.AddComponent<SpriteRenderer>();
        _spriteRenderer.sprite = EnemyData.Sprite;
        if (EnemyData.RotateRandomly)
        {
            sprite.transform.Rotate(0, 0, Random.Range(0, 360));
        }
        // Load data from EnemyData
        Health = EnemyData.MaxHealth;
        // Do repeating attack if exists
        if (Attacks.Cooldown > 0)
        {
            InvokeRepeating("RepeatedAttack", Attacks.Cooldown, Attacks.Cooldown);
        }
        // Initiate charged attack if exists
        if (Attacks.ChargeTime > 0)
        {
            StartCoroutine(ChargedAttack());
        }
    }

    // Helper functions for calling attack behavior
    void RepeatedAttack() { Attacks.RepeatedAttack(gameObject); }
    IEnumerator ChargedAttack() { yield return new WaitForSeconds(Attacks.ChargeTime); Attacks.ChargedAttack(gameObject); }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // If hit the player, deal damage and die
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStatistics.instance.loseHealth(EnemyData.ContactDamage);
            TooltipManager.Instance.DisplayTooltip(TooltipManager.TooltipType.PlayerDamage, EnemyData.ContactDamage, transform.position);
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        // Display tooltip
        TooltipManager.Instance.DisplayTooltip(TooltipManager.TooltipType.EnemyDamage, damage, transform.position);
        Health -= damage;
        if (Health <= 0)
        {
            StartCoroutine(Die(gameObject));
        }
    }

    public IEnumerator Die(GameObject me)
    {
        // Display tooltip and award money
        int reward = Random.Range(EnemyData.MinReward, EnemyData.MaxReward);
        TooltipManager.Instance.DisplayTooltip(TooltipManager.TooltipType.Money, reward, transform.position);
        PlayerStatistics.instance.changeMoney(reward);
        // Get smaller and smaller
        for (int i = 0; i < 10; i++)
        {
            me.transform.localScale *= 0.9f;
            yield return new WaitForSeconds(0.1f);
        }
        // Die
        Destroy(me);
        yield return null;
    }
}
