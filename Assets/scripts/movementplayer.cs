using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public GameManager Gm;
    public GameObject currentNode;
    public float speed = 3f;
    public string direction = "";
    public string lastMovDirec = "";
    // Start is called before the first frame update
    public bool CanWarp = true;
    void Awake()
    {
        Gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Ncontroller CurrentNodecontroller = currentNode.GetComponent<Ncontroller>();
        transform.position = Vector2.MoveTowards(transform.position, currentNode.transform.position, speed * Time.deltaTime);
        bool reverseDirection = false;
        if ((direction == "Left" && lastMovDirec == "Right")||
                (direction == "Right" && lastMovDirec == "down")||
                (direction == "up" && lastMovDirec == "Right")|| (direction == "down" && lastMovDirec == "up"))
        {
            reverseDirection = true;
        }

            if ((transform.position.x == currentNode.transform.position.x && transform.position.y == currentNode.transform.position.y) || reverseDirection)
        {
            if(currentNode==Gm.leftWarpNode && direction=="Left" && CanWarp )
            {
                currentNode = Gm.rightWarpNode;
                direction = "Left";
                lastMovDirec = "Left";
                transform.position = currentNode.transform.position;
                CanWarp = false;
            }
            else if (currentNode ==Gm.rightWarpNode && direction == "Right" && CanWarp )
            {
                currentNode = Gm.leftWarpNode;
                direction = "Right";
                lastMovDirec = "Right";
                transform.position = currentNode.transform.position;
                CanWarp = false;
            }
            else {
                GameObject newNode = CurrentNodecontroller.GetNodeFromDirection(direction);
                if (newNode != null)
                {
                    currentNode = newNode;
                    lastMovDirec = direction; 

                }

                else
                {
                    direction = lastMovDirec;
                    newNode = CurrentNodecontroller.GetNodeFromDirection(direction);
                    if (newNode != null)
                    {
                        currentNode = newNode;

                    }


                }
            }
        }
       else
        {
            CanWarp = true;
       }
            
    }
    public void SetDirection(string newDirection)
    {
        direction = newDirection;
    }
}
