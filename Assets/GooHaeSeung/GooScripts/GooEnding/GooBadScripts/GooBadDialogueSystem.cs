using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GooBadDialogueSystem : MonoBehaviour
{
    public Text txtName;
    public Text txtSentence;

    Queue<string> sentences = new Queue<string>();

    public Animator anim;

    public void Beign(GooBadDialogue info)
    {
        anim.SetBool("GooIsOpen",true);

        sentences.Clear();

        txtName.text = info.name;

        foreach(var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }
        Next();
    }

    public void Next()
    {
        if (sentences.Count == 0)
        {
            End();
            return;
        }

        txtSentence.text = string.Empty;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentences.Dequeue()));
    }

    IEnumerator TypeSentence(string sentence)
    {
        foreach(var letter in sentence)
        {
            txtSentence.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void End()
    {
        anim.SetBool("GooIsOpen", false);
        txtSentence.text = string.Empty;
        StartCoroutine(Hos());
    }

    IEnumerator Hos()
    {
        yield return new WaitForSeconds(1.5f);
        //SceneManager.LoadScene("GooHos");
    }
}

