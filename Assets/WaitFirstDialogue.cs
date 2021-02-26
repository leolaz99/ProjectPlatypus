using UnityEngine;

public class WaitFirstDialogue : MonoBehaviour
{
    public GameObject firstDialogue;

    private void Start()
    {
        Invoke("ActiveFirstDialogue", 7f);
    }
    public void ActiveFirstDialogue()
    {
        firstDialogue.SetActive(true);
    }
}
