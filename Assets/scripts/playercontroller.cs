using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    movementplayer Movementplayer;
    // Start is called before the first frame update

    public SpriteRenderer sprite;
    public Animator animator;
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
       Movementplayer = GetComponent<movementplayer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("moving", true);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Movementplayer.SetDirection("Left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Movementplayer.SetDirection("Right");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Movementplayer.SetDirection("up");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Movementplayer.SetDirection("down");
        }
        bool flipX = false;
        bool flipY = false;
        if (Movementplayer.lastMovDirec == "Left")
        {
            animator.SetInteger("direction", 0);
        }
        else if (Movementplayer.lastMovDirec == "Right")
        {
            animator.SetInteger("direction", 0);
            flipX = true;
        }
        else if (Movementplayer.lastMovDirec == "down")
        {
            animator.SetInteger("direction", 1);
            flipY = true;
        }
        else if (Movementplayer.lastMovDirec == "up")
        {
            animator.SetInteger("direction", 1);
        }

        sprite.flipX = flipX;
        sprite.flipY = flipY;
    }
}
