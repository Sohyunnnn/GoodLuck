using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PinkStickScale : MonoBehaviour
{
    public static double StickA;
    public static double StickB;
    int StickD;

    // Start is called before the first frame update
    void Start()
    {


        StickD = Random.Range(-4, 5);
        transform.position = new Vector3(StickD, 3.14f, 5.88f);

        StickA = StickD - 2.5;
        StickB = StickD + 2.5;

    }

    // Update is called once per frame
    void Update()
    {

    }


}
