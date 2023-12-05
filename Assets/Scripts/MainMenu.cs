using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame() => SceneManager.LoadScene("Gameplay");


    public void PlayAgain()
    { // Destroy singletons as game is over
        Destroy(PlayerStatistics.instance.gameObject);
        StartGame();
    }
    public void Exit() => Application.Quit();
}