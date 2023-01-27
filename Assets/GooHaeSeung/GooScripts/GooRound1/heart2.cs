using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heart2 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (ScoreManager.score >= 1)
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

    IEnumerator gotoRestart()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Restart");
        gameObject.SetActive(false);
    }

    public void heart2active()
    {
        gameObject.SetActive(true);
    }
}
