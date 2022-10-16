using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{   
    public TMP_Text nameText;
    public TMP_Text dialogueText;

    public Animator animator;
    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {   
        #if true
	    animator.SetBool("IsOpen", true);
        #endif
        
        Debug.Log("Starting" + dialogue.name);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string setence in dialogue.senteces){
            sentences.Enqueue(setence);

        }
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        dialogueText.text = sentence;
    }

    void EndDialogue(){
	    animator.SetBool("IsOpen", false);
        Debug.Log("End Conversation");
    }

}
