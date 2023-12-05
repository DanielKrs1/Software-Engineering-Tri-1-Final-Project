using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    { // Destroy singletons as game is over
        Destroy(DataManager.Instance.gameObject);
        Destroy(PlayerStatistics.instance.gameObject);
        SceneManager.LoadScene("sandbox2");
    }


    public void Exit() => Application.Quit();
}