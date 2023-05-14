using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public GameObject currentNode;
    public float speed = 4f;
    public string direction = "";
    public string lastMovDirec = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ncontroller CurrentNcontroller = currentNode.GetComponent<Ncontroller>();
        transform.position = Vector2.MoveTowards(transform.position, currentNode.transform.position, speed * Time.deltaTime);

        if (transform.position.x == currentNode.transform.position.x && transform.position.y == currentNode.transform.position.y)
        {
            GameObject newNode = CurrentNcontroller.GetNodeFromDirection(direction);
            if (newNode != null)
            {
                currentNode = newNode;
                lastMovDirec = direction;

            }

            else
            {
                direction = lastMovDirec;
                newNode = CurrentNcontroller.GetNodeFromDirection(direction);
                if (newNode != null)
                {
                    currentNode = newNode;

                }

         
            }
        }
    }
    public void SetDirection(string newDirection)
    {
        direction = newDirection;
    }
}
