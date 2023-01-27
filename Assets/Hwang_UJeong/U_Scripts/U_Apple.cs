/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_Apple : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManager sm = smObject.GetComponent<ScoreManager>();
            sm.appleAmount += 1; //»ç°ú È¹µæ ½Ã È¹µî·® 1 Áõ°¡
            sm.appleAmountUI.text = "È¹µæ »ç°ú: " + sm.appleAmount;

            Destroy(gameObject);//»ç°ú¿¡ ´êÀ¸¸é »ç°ú »èÁ¦

            Sfx.SoundPlay();//»ç°ú È¹µæ ½Ã È¿°úÀ½ ¹ß»ý
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}*/