using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
	public Dialogue dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            TriggerDialogue();
    }

    public void TriggerDialogue()
	{
		DialogueManager.instance.StartDialogue(dialogue);
	}
}