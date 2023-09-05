using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{ 
    private float Speed = 2.5f;
    public float JumpForse = 5;
    public bool FaceRight = true;
    private bool isGround;
    private bool FaseRot = true;
    private Animator anim;
    private Rigidbody2D rb;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        MoveLogic();
        JumpLogic();
        HorizontalRotation();
    }

    private void HorizontalRotation()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            FaceRight = true;

            Quaternion rot = transform.rotation;
            rot.y = 0;
            transform.rotation = rot;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            FaceRight = false;

            Quaternion rot = transform.rotation;
            rot.y = 180;
            transform.rotation = rot;
            anim.SetBool("BoolRun", true);
        }
    }
    private void MoveLogic()
    {
        //Move
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(hor, ver);
        rb.velocity = move * Speed;

        //Anim_Horizontal
        if (hor == 0)
        {
            anim.SetBool("BoolRun", false);
        }
        else if (hor > 0)
        {
            anim.SetBool("BoolRun", true);

        }
        else
        {
            anim.SetBool("BoolRun", false);
        }

        //Anim_Vertical
        if (ver == 0)
        {
            anim.SetBool("BoolRun2", false);
            anim.SetBool("BoolRun3", false);
        }
        else if (ver > 0)
        {
            anim.SetBool("BoolRun2", true);
        }
        else if (ver < 0)
        {
            anim.SetBool("BoolRun3", true);
        }
        else
        {
            anim.SetBool("BoolRun2", false);
            anim.SetBool("BoolRun3", false);
        }

    }
    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (isGround)
            {
                rb.AddForce(Vector2.one * JumpForse);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsGroundUpate(collision, true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        IsGroundUpate(collision, false);
    }

    private void IsGroundUpate(Collision2D collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        { 
            isGround = value;
        }
    }
}
