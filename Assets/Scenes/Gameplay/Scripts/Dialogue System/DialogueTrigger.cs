using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public PowerUpManager powerUpManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        powerUpManager.powerUpCounter++;
        DialogueManager.instance.StartDialogue(dialogue);
    }

    private void OnTriggerExit(Collider other)
    {
        this.gameObject.SetActive(false);
    }
}
