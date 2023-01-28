using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GooBad : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void bad()
    {
        GooGameBackMusic.GooMusic = -1;
        SceneManager.LoadScene("GooBadEnding");
    }
}
