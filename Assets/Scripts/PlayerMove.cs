using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    public float moveSpeed = 7;

    CharacterController cc;

    float gravity = -20f;

    public float yVelocity = 0;

    //public float jumpPower = 10f;
    public float jumpPower = 5f;

    public bool isButton = false;

    public bool doubleJumpState = false;
    
    public float spped = 5f;
    public float moveX;

    Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * moveSpeed * Time.deltaTime;

        /*if (isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false;
            yVelocity = 0;
        }

        if (!isJumping && Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
            isJumping = true;
        }
        */


        // if(Input.GetButton("Jump")&&!isJumping)
        // {
        //     yVelocity = jumpPower;
        //    isJumping = true;
        // }
        // 

        if (cc.velocity.y == 0)
            isButton = true;
        else
            isButton = false;
        if (isButton)
            doubleJumpState = true;

        if (isButton && Input.GetButtonDown("Jump"))
            JumpAddForce();
        else if (doubleJumpState&&Input.GetButtonDown("Jump"))
        {
            JumpAddForce();
            doubleJumpState = false;
        }

        moveX = Input.GetAxis("Horizontal") * spped;
        //cc.velocity = new Vector3(moveX, cc.velocity.y);

        void JumpAddForce()
        {
            cc.velocity = new Vector3(cc.velocity.x, 0f, cc.velocity.z);
            cc.AddForce(Vector3.up * jumpPower);
        }



        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
