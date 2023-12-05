using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Text healthTextBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthTextBox.text = "" + PlayerStatistics.instance.currentHealth + "/" +  PlayerStatistics.instance.maxHealth + " HP";
    }
}
