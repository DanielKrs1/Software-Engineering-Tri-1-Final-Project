using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class level_system
{
    SpawnerDummy enemySpawner;
    PlayerStatistics playerStatistics;
    DataManager dataManager;

    [SetUp]
    public void Init()
    {
        GameObject TestManager = new GameObject("Controller");
        // Create singletons
        TestManager.AddComponent<PlayerStatistics>();
        playerStatistics = TestManager.GetComponent<PlayerStatistics>();
        TestManager.AddComponent<DataManager>();
        dataManager = TestManager.GetComponent<DataManager>();

        // Set up enemy spawner
        GameObject easy = new GameObject("Easy")
        {
            tag = "Test"
        };
        GameObject hard = new GameObject("Hard")
        {
            tag = "Test"
        };
        TestManager.AddComponent<SpawnerDummy>();
        enemySpawner = TestManager.GetComponent<SpawnerDummy>();

        enemySpawner.EasyEnemies = new GameObject[] { easy };
        enemySpawner.HardEnemies = new GameObject[] { hard };

    }

    [Test]
    public void distance_increases_with_level()
    {
        Debug.Log(playerStatistics.levelNumber);
        playerStatistics.levelNumber = 1;
        float Level1Distance = dataManager.maxDist;
        playerStatistics.levelNumber = 10;
        float Level10Distance = dataManager.maxDist;

        Assert.Less(Level1Distance, Level10Distance);
    }

    [Test]
    public void speed_increases_with_level()
    {

        playerStatistics.levelNumber = 1;
        float Level1Speed = dataManager.scrollSpeed;
        playerStatistics.levelNumber = 10;
        float Level10Speed = dataManager.scrollSpeed;

        Assert.Less(Level1Speed, Level10Speed);
    }

    [Test]
    public void health_increases_with_level()
    {
        GameObject FakeEnemy = new GameObject("EnemyDummy");
        EnemyTemplate dummy = new EnemyTemplate();
        FakeEnemy.AddComponent<EnemyDummy>();
        EnemyDummy testEnemy = FakeEnemy.GetComponent<EnemyDummy>();

        testEnemy.EnemyData = dummy;

        playerStatistics.levelNumber = 1;
        testEnemy.Init();
        int Level1Health = testEnemy.Health;

        playerStatistics.levelNumber = 10;
        testEnemy.Init();
        int Level10Health = testEnemy.Health;

        Assert.Less(Level1Health, Level10Health);
    }

    [Test]
    public void spawn_interval_decreases_with_level()
    {

        playerStatistics.levelNumber = 1;
        float Level1Interval = enemySpawner.SpawnInterval;
        playerStatistics.levelNumber = 10;
        float Level10Interval = enemySpawner.SpawnInterval;

        Assert.Less(Level10Interval, Level1Interval);
    }

    [Test]
    public void easy_probability_decreases_on_higher_levels()
    {

        playerStatistics.levelNumber = 1;
        enemySpawner.Init();
        float Level1Probability = enemySpawner.EasyProbability;

        playerStatistics.levelNumber = 10;
        enemySpawner.Init();
        float Level10Probability = enemySpawner.EasyProbability;

        Assert.Less(Level10Probability, Level1Probability);
    }


    [Test]
    public void high_easy_probability_means_easy_enemies()
    {

        enemySpawner.EasyProbability = 1.0f;
        enemySpawner.Spawn();
        Assert.AreEqual("Easy", GameObject.FindGameObjectsWithTag("Test")[0].name);
        Object.Destroy(GameObject.FindGameObjectsWithTag("Test")[0]);

    }

    [Test]
    public void low_easy_probability_means_hard_enemies()
    {

        enemySpawner.EasyProbability = 0.0f;
        enemySpawner.Spawn();
        Assert.AreEqual("Hard", GameObject.FindGameObjectsWithTag("Test")[0].name);
        Object.Destroy(GameObject.FindGameObjectsWithTag("Test")[0]);

    }
}

public class EnemyDummy : EnemyController
{
    public void Init() { Start(); }
}

public class SpawnerDummy : EnemySpawner
{
    public void Init() { Awake(); }
}