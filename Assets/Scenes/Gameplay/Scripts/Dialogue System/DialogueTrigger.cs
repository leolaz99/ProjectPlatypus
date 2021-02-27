using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public PowerUpManager powerUpManager;
    [TextArea(3, 10)]
    public string tutorialSentence;
    public Text tutorialText;
    public float tutorialTime;
    public static DialogueTrigger instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            TriggerDialogue();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(this.gameObject);

    }


    public IEnumerator ShowTutorial()
    {
        tutorialText.text = tutorialSentence;
        tutorialText.gameObject.SetActive(true);
        yield return new WaitForSeconds(tutorialTime);
        tutorialText.gameObject.SetActive(false);
    }

    public void TriggerDialogue()
    {
        powerUpManager.powerUpCounter++;
        DialogueManager.instance.StartDialogue(dialogue);
    }
}
