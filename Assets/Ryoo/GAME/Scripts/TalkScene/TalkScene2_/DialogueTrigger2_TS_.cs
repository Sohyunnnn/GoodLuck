using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger2_TS_ : MonoBehaviour
{
    public Dialogue info;

    public Animator anim;

    public void Trigger()
    {
        anim.SetBool("isClick", true);

        var system = FindObjectOfType<DialogueSystem2_TS_>();
        system.Begin(info);
    }

}
