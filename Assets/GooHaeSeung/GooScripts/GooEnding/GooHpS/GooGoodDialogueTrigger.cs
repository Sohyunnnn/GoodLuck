using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooGoodDialogueTrigger : MonoBehaviour
{
    public GooGoodDialogue info;

    public void Trigger()
    {
        var system = FindObjectOfType<GooGoodDialogueSystem>();
        system.Beign(info);
        gameObject.SetActive(false);
    }
}
