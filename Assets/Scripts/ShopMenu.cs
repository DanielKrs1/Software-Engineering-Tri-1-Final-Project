using UnityEngine.SceneManagement;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public void NextLevel()
    { 
        PlayerStatistics.instance.nextLevel();
        // Reset distance
        
        SceneManager.LoadScene("sandbox2");
    }


}