using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    movementplayer Movementplayer;
    // Start is called before the first frame update
    void Start()
    {
       Movementplayer = GetComponent<movementplayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Movementplayer.SetDirection("left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Movementplayer.SetDirection("right");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Movementplayer.SetDirection("up");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Movementplayer.SetDirection("down");
        }
    }
}
