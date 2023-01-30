using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{

    public string gameScene = "Opening"; // 게임 시작 씬 이름 넣기

    public Animator animator;


    public void clickStart()
    {
        Debug.Log("ClickStart");

        // StartCoroutine(FadeCoroutine());

        //SceneManager.LoadScene(gameScene);

        Invoke("nextScene", 1f);
    }

    public void clickHow()
    {
        Debug.Log("ClickHow");

    }

    public void clickExit()
    {
        Debug.Log("ClickExit");
        Application.Quit();
    }

    private void nextScene()
    {
        SceneManager.LoadScene("Opening1");
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
