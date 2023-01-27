using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GooGameManager2 : MonoBehaviour
{
    public static GooGameManager2 gm2;

    private void Awake()
    {
        if (gm2 == null)
        {
            gm2 = this;
        }
    }
    public enum GameState2
    {
        Ready,
        Run,
        GameOver
    }

    public GameState2 gstate;

    public GameObject gameLabel;

    Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        gstate = GameState2.Ready;

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

        gstate = GameState2.Run;
    }
}
