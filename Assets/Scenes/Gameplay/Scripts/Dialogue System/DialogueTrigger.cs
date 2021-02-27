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

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(this.gameObject);
    }


    public void TriggerDialogue()
    {
        powerUpManager.powerUpCounter++;
        DialogueManager.instance.StartDialogue(dialogue);
    }
}
