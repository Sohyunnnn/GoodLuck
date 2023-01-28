using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooBadDialogueTrigger2 : MonoBehaviour
{
    public GooBadDialogue2 info;

    public void Trigger()
    {
        var system = FindObjectOfType<GooHOSsystem>();
        system.Beign(info);
        gameObject.SetActive(false);
    }
}
