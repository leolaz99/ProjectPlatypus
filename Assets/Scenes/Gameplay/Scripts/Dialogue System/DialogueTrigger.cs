using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public PowerUpManager powerUpManager;
    [TextArea(3, 10)]
    public string tutorialSentence;
    public Text tutorialText;
    public float tutorialTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            TriggerDialogue();
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(ShowTutorial());
    }

    public IEnumerator ShowTutorial()
    {
        tutorialText.text = tutorialSentence;
        tutorialText.gameObject.SetActive(true);
        yield return new WaitForSeconds(tutorialTime);
        tutorialText.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
    
    public void TriggerDialogue()
    {
        powerUpManager.powerUpCounter++;
        DialogueManager.instance.StartDialogue(dialogue);
    }
}
