using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public Text levelTextBox;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        levelTextBox.text = "Level " + PlayerStatistics.instance.levelNumber;
    }
}
