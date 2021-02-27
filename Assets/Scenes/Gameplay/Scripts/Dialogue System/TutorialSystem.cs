using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialSystem : MonoBehaviour
{
    public Text tutorialText;
    public float tutorialTime;
    public PowerUpManager powerUp;

    public static TutorialSystem instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public IEnumerator ShowTutorial()
    {
        if(powerUp.powerUpCounter==1)
            tutorialText.text = "q";

        if (powerUp.powerUpCounter == 2)
            tutorialText.text = "w";
        
        if (powerUp.powerUpCounter == 3)
            tutorialText.text = "e";
        
        if (powerUp.powerUpCounter == 4)
            tutorialText.text = "r";

        tutorialText.gameObject.SetActive(true);
        yield return new WaitForSeconds(tutorialTime);
        tutorialText.gameObject.SetActive(false);
    }
}
