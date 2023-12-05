using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public void StartGame() => SceneManager.LoadScene("sandbox2");

    public void Exit() => Application.Quit();
}