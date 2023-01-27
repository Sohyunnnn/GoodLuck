using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooPinkStickScale3 : MonoBehaviour
{
    public static double StickA2;
    public static double StickB2;
    int StickD;

    // Start is called before the first frame update
    void Start()
    {
        StickD = Random.Range(-4, 5);
        transform.position = new Vector3(StickD, 3.14f, 5.88f);

        StickA2 = StickD - 1;
        StickB2 = StickD + 1;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
