using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene: MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("UI-MainMenu");
    }

    public void LoadMenuPlay()
    {
        SceneManager.LoadScene("UI-Play");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Theoscene");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("UI-Settings");
    }
}
