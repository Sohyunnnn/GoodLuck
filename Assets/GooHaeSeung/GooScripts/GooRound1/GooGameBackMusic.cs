using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GooGameBackMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject bgm;
    public static int GooMusic; 

     void Start()
    {
        GooMusic = 0;
        DontDestroyOnLoad(bgm);
    }


    private void Update()
    {
        if (GooMusic > 0)
        {
            audioSource.Stop();
        }
        if (GooMusic < 0)
        {
            Destroy(gameObject);
        }
    }
}
