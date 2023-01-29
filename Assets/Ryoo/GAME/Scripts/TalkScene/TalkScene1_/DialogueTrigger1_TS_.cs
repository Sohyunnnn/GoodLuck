using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger1_TS_ : MonoBehaviour
{
    public Dialogue info;

    public Animator anim;

    public void Trigger()
    {
        anim.SetBool("isClick", true);

        var system = FindObjectOfType<DialogueSystem1_TS_>();
        system.Begin(info);
    }

}
