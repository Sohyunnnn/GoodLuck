using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GooRestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moving()
    {
        ScoreManager.score = 2;
        GooGameBackMusic.GooMusic = 0;
        SceneManager.LoadScene("GooRound1");
    }
}
