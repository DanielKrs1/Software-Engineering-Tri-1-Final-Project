using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipManager : MonoBehaviour
{
    private static TooltipManager _instance;
    public static TooltipManager Instance { get { return _instance; } }
    public enum TooltipType
    {
        Damage,
        Money
    }
    public GameObject TooltipPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Singleton pattern - keep only one copy of data
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
    }
    public void DisplayTooltip(TooltipType type, int amount, Vector3 position)
    {
        GameObject tooltip = Instantiate(TooltipPrefab, position, Quaternion.identity);
        tooltip.transform.SetParent(transform);
        switch (type)
        {
            case TooltipType.Damage:
                tooltip.GetComponent<TextMeshProUGUI>().text = amount.ToString();
                // Set text color to red
                tooltip.GetComponent<TextMeshProUGUI>().color = Color.red;
                break;
            case TooltipType.Money:
                tooltip.GetComponent<TextMeshProUGUI>().text = "+" + amount.ToString();
                // Set text color to green
                tooltip.GetComponent<TextMeshProUGUI>().color = Color.green;
                break;
        }
    }
}
