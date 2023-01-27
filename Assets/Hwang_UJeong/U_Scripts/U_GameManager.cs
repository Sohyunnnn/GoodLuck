using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class U_GameManager : MonoBehaviour
{
    public static U_GameManager gm;

    [SerializeField]
    private int minutes;
    private float timeValue;
    private float lastTimeToHead;

    [SerializeField]
    private Transform Head;
    [SerializeField]
    private int headTimer;

    [SerializeField]
    private Text timeText;

    [SerializeField]
    private AudioSource dollSing;
    [SerializeField]
    private AudioSource dollHeadOff;
    [SerializeField]
    private AudioSource dollHeadOn;
    [SerializeField]
    AudioSource feetSteps;

    public static bool headTime;
    public static bool headTimeFinish;

    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        headTime = false;
        timeValue = minutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            SceneManager.LoadScene("EndScene");
        }

        DisplayTime(timeValue);
    }

    private void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
            timeToDisplay = 0;

        float mins = Mathf.FloorToInt(timeToDisplay / 60);
        float secs = Mathf.FloorToInt(timeToDisplay % 60);
        HeadTime(secs);

        timeText.text = string.Format("{0:00}:{1:00}", mins, secs);
    }

    private void HeadTime(float secs)
    {
        if (timeValue <= 0)
        {
            headTimeFinish = true;
            RotHead(180); //팬더 머리돌리기
            return;
        }

        if (secs % headTimer == 0 && secs != lastTimeToHead)
        {
            lastTimeToHead = secs;
            headTime = !headTime;

            if (headTime)
            {
                dollHeadOn.Play(0);
            }
            else
            {
                if (!dollSing.isPlaying)
                    dollHeadOff.Play(0);

                if (!dollSing.isPlaying)
                    dollSing.PlayDelayed(1);
            }
        }

        if (headTime)
            RotHead(180);
        else
            RotHead(0);
    }

    private void RotHead(int deg)
    {
        Vector3 direction = new Vector3(Head.rotation.eulerAngles.x, deg, Head.rotation.eulerAngles.z);
        Quaternion targetRotation = Quaternion.Euler(direction);
        Head.rotation = Quaternion.Lerp(Head.rotation, targetRotation, Time.deltaTime * 3);
    }

    public void StopSounds()
    {
        dollSing.Stop();
        dollHeadOff.Stop();
        dollHeadOn.Stop();
        feetSteps.Stop();
    }
}