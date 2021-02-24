using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
	public static DialogueManager instance;
	public Text nameText;
	public Text dialogueText;
	[HideInInspector]
	public bool isTalk = false;

	public Animator animator;

	private Queue<string> sentences;

	void Awake()
	{
		sentences = new Queue<string>();
		
		if (instance == null)
			instance = this;
	}

	public void StartDialogue(Dialogue dialogue)
	{
		animator.SetBool("isOpen", true);
		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		isTalk = true;

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
			yield return new WaitForSeconds(.05f);
		}
	}

	void EndDialogue()
	{
		isTalk = false;
		animator.SetBool("isOpen", false);
	}
}
