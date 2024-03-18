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

    public void LoadGameInfinite()
    {
        SceneManager.LoadScene("SceneGameInfinite");
    }
    public void LoadGameTimer()
    {
        SceneManager.LoadScene("SceneGameTimer");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("UI-Settings");
    }
}
