using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject credits;

    [SerializeField]
    private Image _blackPanel;
    [SerializeField]
    private GameObject _blackObject;


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

    public void PlayButtonClicked()
    {
        BlackPanelAppears();
        FadeIn();
        Invoke("GoToGame", 0.5f);
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


    private void FadeIn()
    {
        //cambia l'alpha del pannello nero a 1(totalmente nero) in X secondi(secondo paramentro) dopo averla impostata a 0
        _blackPanel.canvasRenderer.SetAlpha(0f);
        _blackPanel.CrossFadeAlpha(1, 0.4f, false);
    }

    private void BlackPanelAppears()
    {
        //disattiva il gameobject del pannello nero

        _blackObject.SetActive(true);
    }

}
