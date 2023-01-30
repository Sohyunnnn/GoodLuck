using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Talk3 : MonoBehaviour
{
    //public Dialogue info;

    //public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if(collision.gameObject.name == "G1_Black")
    //    {
    //        Debug.Log("collision");
    //        if (Input.GetKeyDown(KeyCode.Q))
    //        {
    //            Debug.Log("collision2");
    //            GetComponent<DialogueTrigger_GS>().Trigger();
    //        }
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.LookAt(other.transform);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("collision2");
                Invoke("nextScene", 0.5f);
            }
        }
    }

    private void nextScene()
    {
        Debug.Log("씬 이동 (딱지치기 대화)");
        SceneManager.LoadScene("TalkScene3");
    }

    //public void Trigger()
    //{
    //    anim.SetBool("isClick", true);


    //    var system = FindObjectOfType<DialogueSystem_GS>();
    //    system.Begin(info);
}

