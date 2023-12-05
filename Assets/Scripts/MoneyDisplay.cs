using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    public Text moneyTextBox;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moneyTextBox.text = "$" + PlayerStatistics.instance.currentMoney;
    }
}
