using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator anim;
    public float runSpeed = 40f;

    float horizontalMove =  0f;

    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("Hops", true);
        }
    }


    void FixedUpdate()
    {
        // Move Character
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
        anim.SetBool("Hops", false);
    }
   
}
