using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene: MonoBehaviour
{
    public void UIMenu()
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
}
