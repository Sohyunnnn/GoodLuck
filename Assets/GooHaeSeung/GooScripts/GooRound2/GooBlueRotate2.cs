using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GooBlueRotate2 : MonoBehaviour
{
    public GameObject gameLabel;
    Text WinText;

    bool isCollided = false;

    // public GameObject SecoundRound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        //for (int i = 0; i < 1; i++)

        if (isCollided == false && col.gameObject.name == "RedDaak")
        {
            this.transform.Rotate(0, 0, -90);
            Invoke("onemoretime", 0.5f);
            print("hit");

            StartCoroutine(RedWin());

            //col.collider.enabled = false;

            isCollided = true;
        }

    }



    void onemoretime()
    {
        this.transform.Rotate(0, 0, -90);
    }



    IEnumerator RedWin()
    {
        yield return new WaitForSeconds(1.5f);

        WinText = gameLabel.GetComponent<Text>();
        WinText.text = "ÆÄ¶õ µüÁö°¡ ³Ñ¾î°¬´Ù!";
        WinText.color = new Color32(0, 0, 0, 255);

        yield return new WaitForSeconds(2f);

        gameLabel.SetActive(false);

        SceneManager.LoadScene("GooRound3");

    }
}