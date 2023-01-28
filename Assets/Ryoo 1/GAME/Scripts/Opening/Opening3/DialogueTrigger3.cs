using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger3 : MonoBehaviour
{
    public Dialogue info;

    public Animator anim;

    public void Trigger()
    {
        anim.SetBool("isClick", true);

        var system = FindObjectOfType<DialogueSystem3>();
        system.Begin(info);
    }

}
