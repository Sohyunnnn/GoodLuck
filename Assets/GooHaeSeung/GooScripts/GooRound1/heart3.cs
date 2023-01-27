using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart3 : MonoBehaviour
{
    //public static heart3 instance = null;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoreManager.score >= 2)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
