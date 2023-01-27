using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GooRedRotate2 : MonoBehaviour
{
    public GameObject targetPosition1;
    public GameObject targetPosition2;
    public GameObject gameLabel;

    Text falseText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sucess()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPosition1.transform.position, 8f);
        this.transform.Rotate(0, 0, -90);
        Invoke("onemoretime", 0.1f);
        print("hit");

        StartCoroutine(SuccessSecoundRound());
    }

    public void flase()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition2.transform.position, 8f);
        this.transform.Rotate(0, 0, -90);
        Invoke("onemoretime", 0.1f);
   
        StartCoroutine(FalseSecoundRound());
    }

    void onemoretime()
    {
        this.transform.Rotate(0, 0, -90);
    }

    IEnumerator SuccessSecoundRound()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("GooRound3");
    }

    IEnumerator FalseSecoundRound()
    {
        yield return new WaitForSeconds(1.5f);

        falseText = gameLabel.GetComponent<Text>();
        falseText.text = ("파란 딱지를 넘기는데 실패했다!");
        falseText.color = new Color32(0, 0, 0, 255);
        ScoreManager.score--;
        yield return new WaitForSeconds(2f);

        gameLabel.SetActive(false);

        if (ScoreManager.score >= 1)
        {
            SceneManager.LoadScene("GooRound3");
        }
        else
        {
            SceneManager.LoadScene("GooRestart");
        }
    }
}
