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
	private Queue<string> names;

	void Awake()
	{
		sentences = new Queue<string>();
		names = new Queue<string>();

		if (instance == null)
			instance = this;
	}

	public void StartDialogue(Dialogue dialogue)
	{
		animator.SetBool("isOpen", true);

		sentences.Clear();
		names.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		foreach (string name in dialogue.name)
		{
			names.Enqueue(name);
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
		string name = names.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
		StartCoroutine(TypeName(name));
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

	IEnumerator TypeName(string name)
	{
		nameText.text = "";
		foreach (char letter in name.ToCharArray())
		{
			nameText.text += letter;
			yield return new WaitForSeconds(.05f);
		}
	}

	void EndDialogue()
	{
		isTalk = false;
		animator.SetBool("isOpen", false);
	}
}
