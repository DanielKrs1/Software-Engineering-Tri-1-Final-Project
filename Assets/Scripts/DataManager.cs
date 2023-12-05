using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static DataManager _instance;
    public static DataManager Instance { get { return _instance; } }

    public float distance;
    public float maxDistConst = 100; // TODO: replace with more proper solution
    public float scrollSpeedConst = 10;
    public float leftBound = -15;
    private void Awake()
    {
        // Singleton pattern - keep only one copy of data
        // TODO: Unit test
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
        distance = 0;
    }

    public float maxDist
    {
        get
        {
            return maxDistConst * Mathf.Pow(PlayerStatistics.instance.levelNumber, 0.5f);
        }
    }
    public float scrollSpeed
    {
        get
        {
            return scrollSpeedConst * Mathf.Pow(PlayerStatistics.instance.levelNumber, 0.25f);
        }
    }
    private void Update()
    { // TODO: Replace with a more proper solution
      // TODO: Unit test
        if (distance < maxDist) distance += scrollSpeed * Time.deltaTime;
        if (distance > maxDist) distance = maxDist;
    }
}
