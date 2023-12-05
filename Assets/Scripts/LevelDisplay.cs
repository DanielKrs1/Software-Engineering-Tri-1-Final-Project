using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public Text levelTextBox;
    public PlayerStatistics playerStatistics;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        levelTextBox.text = "Level " + playerStatistics.levelNumber;
    }
}
