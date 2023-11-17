using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public void StartGame() => SceneManager.LoadScene("Gameplay");

    public void Exit() => Application.Quit();
}