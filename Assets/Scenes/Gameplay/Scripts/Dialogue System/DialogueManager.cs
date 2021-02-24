using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
	public static DialogueManager instance;
	public Text nameText;
	public Text dialogueText;
	[SerializeField] GameObject dialoguePanel;

	private Queue<string> sentences;

	void Awake()
	{
		sentences = new Queue<string>();
		
		if (instance == null)
			instance = this;
	}

	public void StartDialogue(Dialogue dialogue)
	{
		dialoguePanel.gameObject.SetActive(true);
		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		dialoguePanel.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
}
