using UnityEngine;
using UnityEngine.SceneManagement;


public class FinalDialogueManager : MonoBehaviour
{
    [SerializeField] GameObject finalDialogue;
    [SerializeField] GameObject specialDialogue;
    [SerializeField] Eat eat;
    public PowerUpManager powerUpManager;
    public DialogueManager dialogueManager;

    void Win()
    {
        if (powerUpManager.powerUpCounter >= 5 && dialogueManager.isTalk == false && eat.foodCount < 3)
        {
            AudioManager.instance.Stop("GameMusic");
            AudioManager.instance.Play("WinMusic");  
            SceneManager.LoadScene("Win");
        }
            
        if (powerUpManager.powerUpCounter >= 5 && dialogueManager.isTalk == false && eat.foodCount >= 3)
        {     
            AudioManager.instance.Stop("GameMusic");
            AudioManager.instance.Play("HappyEndingMusic");
            SceneManager.LoadScene("HappyEnding");
        }           
    }

    void Update()
    {
        if (eat.foodCount >= 3)
        {
            specialDialogue.SetActive(true);
            finalDialogue.SetActive(false);
        }

        else
        {
            finalDialogue.SetActive(true);
            specialDialogue.SetActive(false);
        }

        Win();
    }
}
