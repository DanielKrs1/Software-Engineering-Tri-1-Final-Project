using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private Upgrade[] upgrades;
    [SerializeField] private Text notEnoughMoneyText;

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
            button.GetComponentInChildren<TextMeshProUGUI>().text = upgrade.GetShopMessage() + ": \n$" + upgrade.cost;
            button.onClick.AddListener(() => BuyUpgrade(upgrade));
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

    private void BuyUpgrade(Upgrade upgrade) {
        if (PlayerStatistics.instance.currentMoney < upgrade.cost) {
            notEnoughMoneyText.gameObject.SetActive(true);
            return;
        } else {
            notEnoughMoneyText.gameObject.SetActive(false);
        }

        PlayerStatistics.instance.changeMoney(-upgrade.cost);
        upgrade.Apply();
    }

    public void NextLevel()
    {
        PlayerStatistics.instance.nextLevel();
        SceneManager.LoadScene("Gameplay");
    }
}