using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GooGameManager3 : MonoBehaviour
{
    public static GooGameManager3 gm3;

    private void Awake()
    {
        if (gm3 == null)
        {
            gm3 = this;
        }
    }
    public enum GameState3
    {
        Ready,
        Run,
        GameOver
    }

    public GameState3 gstate;

    public GameObject gameLabel;

    Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        gstate = GameState3.Ready;

        gameText = gameLabel.GetComponent<Text>();

        gameText.text = "준비";

        gameText.color = new Color32(255, 185, 0, 255);

        StartCoroutine(ReadyToStart());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ReadyToStart()
    {
        yield return new WaitForSeconds(2f);

        gameText.text = " 시작 !";

        yield return new WaitForSeconds(0.5f);

        gameLabel.SetActive(false);

        gstate = GameState3.Run;
    }
}
