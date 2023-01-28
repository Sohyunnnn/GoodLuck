using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GooWin : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        GooGameBackMusic.GooMusic = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ending()
    {
        SceneManager.LoadScene("GooHPEnding");
    }
}
