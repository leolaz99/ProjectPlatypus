using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void ToMenu()
    {
        AudioManager.instance.Stop("GameMusic");
        AudioManager.instance.Stop("HappyEndingMusic");
        AudioManager.instance.Stop("WinMusic");
        AudioManager.instance.Stop("GameOverMusic");
        AudioManager.instance.Play("MenuMusic");
        SceneManager.LoadScene(0);
    }
}
