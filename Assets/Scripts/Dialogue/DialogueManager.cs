using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;
    public string SceneName;

	public Animator animator;

	private Queue<string> sentences;
    public LevelSelect LVLSLCT;
    public int nomorlevel;

    // Use this for initialization
    void Start () {
		sentences = new Queue<string>();
        LVLSLCT = GameObject.Find("LevelSelect").GetComponent<LevelSelect>();
    }

	public void StartDialogue (Dialogue dialogue)
	{
		animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
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

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

    public void ChangeScene(string SceneName)
    {
        //LVLSLCT.nomorlevel = nomorlevel;
        SceneManager.LoadScene(SceneName);
    }

    void EndDialogue()
	{
		animator.SetBool("IsOpen", false); 
        LVLSLCT.nomorlevel = nomorlevel;
        SceneManager.LoadScene(SceneName);
    }

}
