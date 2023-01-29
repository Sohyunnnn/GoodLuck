using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHow : MonoBehaviour
{

    public Animator anim;

    public void clickHow()
    {
        anim.SetBool("clickHow", true);
    }

    public void exitHow()
    {
        anim.SetBool("clickHow", false);
    }
}
