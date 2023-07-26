using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Girl : MonoBehaviour
{
    public Animator playAnim;
    public Rigidbody playerRigid;
    public float walkSpeed, runSpeed, rotateSpeed, walkSlowSpeed;
    public bool walking;
    public Transform playerTrans;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            playerRigid.velocity = transform.forward * walkSpeed * Time.deltaTime ;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))  // 캐릭터 걸을 때 
        {
            playAnim.SetTrigger("walk");
            playAnim.ResetTrigger("idle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playAnim.SetTrigger("idle");
            playAnim.ResetTrigger("walk");
            walking = false;
        }


        if (Input.GetKeyDown(KeyCode.S))  // 캐릭터 뒤로 걸을 때 
        {
            playAnim.SetTrigger("back");
            playAnim.ResetTrigger("idle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playAnim.SetTrigger("idle");
            playAnim.ResetTrigger("back");
            walking = false;
        }
        if (Input.GetKey(KeyCode.A))  // 캐릭터 회전 할때 
        {
            playerTrans.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerTrans.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        if(walking == true)   //  캐릭터가 뛰어 갈때 
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                walkSpeed = walkSpeed + runSpeed;
                playAnim.SetTrigger("run");
                playAnim.ResetTrigger("walk");
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                walkSpeed = walkSlowSpeed ;
                playAnim.SetTrigger("walk");
                playAnim.ResetTrigger("run");
            }
        }
    }
}
