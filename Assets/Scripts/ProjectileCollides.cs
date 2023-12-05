using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollides : MonoBehaviour
{
    // Deals damages to enemies
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyController>().TakeDamage(PlayerStatistics.instance.projectileDamage);
            Destroy(gameObject);
        }
    }
    

}
