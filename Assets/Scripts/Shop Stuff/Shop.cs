using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private Upgrade[] upgrades;

    private Dictionary<Button, Upgrade> shopUpgrades;

    private void Start()
    {
        SetUpShop();
    }

    private void SetUpShop()
    {
        shopUpgrades = new Dictionary<Button, Upgrade>();

        foreach (Button button in buttons)
        {
            Upgrade upgrade = GetUnusedUpgrade();
            shopUpgrades.Add(button, upgrade);
            button.GetComponentInChildren<TextMeshProUGUI>().text = upgrade.GetShopMessage();
        }
    }

    private Upgrade GetUnusedUpgrade()
    {
        Upgrade upgrade;

        do
        {
            upgrade = upgrades[Random.Range(0, upgrades.Length)];
        } while (shopUpgrades.ContainsValue(upgrade));

        return upgrade;
    }

    public void NextLevel()
    {
        PlayerStatistics.instance.nextLevel();
        SceneManager.LoadScene("Gameplay");
    }
}