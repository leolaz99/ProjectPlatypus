using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    public static PauseManager instance;
    public bool isMenuOpen = false;
    public bool isIntroEnd = false;

    public void OpenClosePause()
    {
        if (isMenuOpen == true)
        {
            pausePanel.SetActive(false);
            isMenuOpen = false;
            Time.timeScale = 1;
        }

        else 
        {
            pausePanel.SetActive(true);
            isMenuOpen = true;
            Time.timeScale = 0;
        }      
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Menu");
        AudioManager.instance.Stop("GameMusic");
        AudioManager.instance.Play("MenuMusic");
        Time.timeScale = 1;
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
