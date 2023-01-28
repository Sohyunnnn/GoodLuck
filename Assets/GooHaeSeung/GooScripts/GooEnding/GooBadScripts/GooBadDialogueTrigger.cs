using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooBadDialogueTrigger : MonoBehaviour
{
    public GooBadDialogue info;

    public void Trigger()
    {
        var system = FindObjectOfType<GooBadDialogueSystem>();
        system.Beign(info);
        gameObject.SetActive(false);
    }
}
