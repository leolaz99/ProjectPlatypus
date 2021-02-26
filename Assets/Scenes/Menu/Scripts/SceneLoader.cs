using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject credits;

    public void GoToSettings()
    {
        mainMenu.gameObject.SetActive(false);
        settings.gameObject.SetActive(true);
    }

    public void GoToCredits()
    {
        mainMenu.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
    }

    public void GoToMainMenu()
    {
        credits.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Gameplay");
        AudioManager.instance.Stop("MenuMusic");
        AudioManager.instance.Play("GameMusic");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
