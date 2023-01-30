using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_ChangeScene : MonoBehaviour
{

    public void RestartButton()
    {
        SceneManager.LoadScene("StoneBridge");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
