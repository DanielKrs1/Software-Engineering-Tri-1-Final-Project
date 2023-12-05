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
        EnemyDamage,
        PlayerDamage,
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
        // Random vector offset for the tooltip
        Vector3 adjustment = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(0.5f, 1f), 0);
        GameObject tooltip = Instantiate(TooltipPrefab, position + adjustment, Quaternion.identity);
        TextMeshProUGUI text = tooltip.GetComponent<TextMeshProUGUI>();
        tooltip.transform.SetParent(transform);
        switch (type)
        {
            case TooltipType.PlayerDamage:
                text.text = "-" + amount.ToString();
                // Set text color to red
                text.color = Color.red;
                break;
            case TooltipType.EnemyDamage:
                text.text = amount.ToString();
                // Set text color to red
                text.color = Color.yellow;
                break;
            case TooltipType.Money:
                text.text = "+" + amount.ToString();
                // Set text color to green
                text.color = Color.green;
                break;
        }
    }
}
