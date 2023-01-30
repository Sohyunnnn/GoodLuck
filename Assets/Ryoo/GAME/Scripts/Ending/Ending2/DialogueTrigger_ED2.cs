using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_ED2 : MonoBehaviour
{
    public Dialogue info;

    public Animator anim;

    public void Trigger()
    {
        anim.SetBool("isClick", true);


        var system = FindObjectOfType<DialogueSystem_ED2>();
        system.Begin(info);
    }

}
