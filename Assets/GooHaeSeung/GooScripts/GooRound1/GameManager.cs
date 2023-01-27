using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public static GameManager gm;
    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }
    public enum GameState
    {
        Ready,
        Run,
        GameOver
    }


    public GameState gstate;

    public GameObject gameLabel;

    Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        gstate = GameState.Ready;

        gameText = gameLabel.GetComponent<Text>();

        gameText.text = "준비";

        gameText.color = new Color32(0, 0, 0, 255);

        StartCoroutine(ReadyToStart());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ReadyToStart()
    {
        yield return new WaitForSeconds(2f);

        gameText.text = "시작 !";

        yield return new WaitForSeconds(1f);

        gameLabel.SetActive(false);

        gstate = GameState.Run;
    }
}
