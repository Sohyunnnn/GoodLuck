using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMove : MonoBehaviour
{
    public float startTime;
    public float minX, maxX;
    public float speed;
    public int sign = -1;
    public GameObject RedDaak;
    // public GameObject PinkStick;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GooGameManager.gm.gstate != GooGameManager.GameState.Run)
        {
            return;
        }

        if (Time.time >= startTime)
        {
            transform.position += new Vector3(speed * Time.deltaTime * sign, 0, 0);

            if(transform.position.x < minX)
            {
                transform.position = new Vector3(minX, 3.14f, 5.85f);
                sign *= -1;
            }
            if (transform.position.x > maxX)
            {
                transform.position = new Vector3(maxX, 3.14f, 5.85f);
                sign *= -1;
            }

 
        }

        if (transform.position.x >= PinkStickScale.StickA &&
            transform.position.x <= PinkStickScale.StickB)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RedDaak.GetComponent<RedRotate>().sucess();
                print("ÀÎ½Ä");
                gameObject.SetActive(false);
            }


        }
        else if (transform.position.x <= PinkStickScale.StickA ||
                transform.position.x >= PinkStickScale.StickB)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RedDaak.GetComponent<RedRotate>().flase();
                gameObject.SetActive(false);
            }
        }


    }
}

