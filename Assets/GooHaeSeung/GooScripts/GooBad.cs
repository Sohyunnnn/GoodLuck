using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooBad : MonoBehaviour
{
    public float rotSpeed = 200f;
    float mx = 0;
    float my = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void bad()
    {
        GooGameBackMusic.GooMusic = -1;
    }
}
