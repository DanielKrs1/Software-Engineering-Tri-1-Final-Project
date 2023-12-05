using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] EasyEnemies;
    public GameObject[] HardEnemies;
    public float SpawnX = 15.0f;
    public float SpawnYRange = 5.0f;
    public float FirstSpawnTime = 2.0f;
    public float SpawnIntervalConst = 1.0f;
    void Start()
    { // Spawn faster on later levels
        InvokeRepeating("Spawn", FirstSpawnTime, SpawnIntervalConst * Mathf.Pow(PlayerStatistics.instance.levelNumber, -0.25f));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        if (!DataManager.Instance.reachedEnd)
        { // Don't spawn if the player has reached the end 

            // Scale to harder enemies by level
            float randIndex = Random.Range(0.0f, 1.0f);
            if (randIndex < Mathf.Pow(PlayerStatistics.instance.levelNumber, -0.2f))
            {
                // Spawn easy enemy
                Instantiate(EasyEnemies[Random.Range(0, EasyEnemies.Length - 1)], new Vector3(SpawnX, Random.Range(-SpawnYRange, SpawnYRange), 0), Quaternion.identity);
            }
            else
            {
                // Spawn hard enemy
                Instantiate(HardEnemies[Random.Range(0, HardEnemies.Length - 1)], new Vector3(SpawnX, Random.Range(-SpawnYRange, SpawnYRange), 0), Quaternion.identity);
            }
        }
    }
}
