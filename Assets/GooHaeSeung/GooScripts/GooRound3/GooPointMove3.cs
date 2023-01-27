using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooPointMove3 : MonoBehaviour
{
    public float startTime;
    public float minX, maxX;
    public float speed;
    public int sign = -1;
    public GameObject RedDaak;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (GooGameManager3.gm3.gstate != GooGameManager3.GameState3.Run)
        {
            return;
        }

        if (Time.time >= startTime)
        {
            transform.position += new Vector3(speed * Time.deltaTime * sign, 0, 0);

            if (transform.position.x < minX)
            {
                transform.position = new Vector3(minX, 3.14f, 5.85f);
                sign *= -1;
            }
            if (transform.position.x > maxX)
            {
                transform.position = new Vector3(maxX, 3.14f, 5.85f);
                sign *= -1;
            }

            if (transform.position.x >= GooPinkStickScale3.StickA2 &&
            transform.position.x <= GooPinkStickScale3.StickB2)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    RedDaak.GetComponent<GooRedRotate3>().sucess();
                    gameObject.SetActive(false);
                }


            }
            else if (transform.position.x <= GooPinkStickScale3.StickA2 ||
                    transform.position.x >= GooPinkStickScale3.StickB2)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    RedDaak.GetComponent<GooRedRotate3>().flase();
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
