using System.Collections;
using UnityEngine;
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
        if (powerUp.powerUpCounter == 1)
            tutorialText.text = "Alternate between Q and W to move forward";

        if (powerUp.powerUpCounter == 2)
            tutorialText.text = "Press Left Arrow and Right Arrow to steer";

        if (powerUp.powerUpCounter == 3)
            tutorialText.text = "Press J and K to use the radar to spot shrimps, when you are above them press G to eat\nEat a shrimp will recover one hearth\nEat at least 3 shrimps to get a surprise ";

        if (powerUp.powerUpCounter == 4)
            tutorialText.text = "Press SPACE to attack";
        if (powerUp.powerUpCounter == 4)
            tutorialText.text = "";

        tutorialText.gameObject.SetActive(true);
        yield return new WaitForSeconds(tutorialTime);
        tutorialText.gameObject.SetActive(false);
    }
}
