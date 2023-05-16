using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ncontroller : MonoBehaviour
{
public bool moveleft = false; 
public bool moveright = false; 
public bool moveup = false; 
public bool movedown = false; 

public GameObject nleft;
public GameObject nright;
public GameObject nup;
public GameObject ndown;
public bool isWarpRightNode = false;
public bool isWarpLeftNode = false;





        

    // Start is called before the first frame update
    void Awake()
    { 
        RaycastHit2D[] hitsDown;
    // for shooting 3lshan unzel down  
        hitsDown = Physics2D.RaycastAll(transform.position, -Vector2.up);
    // loop through el l3b objects
        for (int i = 0;i<hitsDown.Length;i++) {
        float distance = Mathf.Abs(hitsDown[i].point.y - transform.position.y);
        if (distance < 0.4f)
            {
            movedown = true;
            ndown = hitsDown[i].collider.gameObject;
            }
    
        }
         RaycastHit2D[] hitsUp;
         // for shooting 3lshan unzel down  
         hitsUp = Physics2D.RaycastAll(transform.position, Vector2.up);
    // loop through el l3b objects
    for (int i = 0; i < hitsUp.Length; i++)
    {
        float distance = Mathf.Abs(hitsUp[i].point.y - transform.position.y);
        if (distance < 0.4f)
        {
            moveup = true;
            nup = hitsUp[i].collider.gameObject;
        }

    }
    RaycastHit2D[] hitsRight    ;
    // for shooting 3lshan unzel  
    hitsRight = Physics2D.RaycastAll(transform.position, Vector2.right);
    // loop through el l3b objects
    for (int i = 0; i < hitsRight.Length; i++)
    {
        float distance = Mathf.Abs(hitsRight[i].point.x - transform.position.x);
        if (distance < 0.4f)
        {
            moveright = true;
            nright = hitsRight[i].collider.gameObject;
        }

    }
    RaycastHit2D[] hitsLeft;
    // for shooting 3lshan unzel down  
    hitsLeft = Physics2D.RaycastAll(transform.position,-Vector2.right);
    // loop through el l3b objects
    for (int i = 0; i < hitsLeft.Length; i++)
    {
        float distance = Mathf.Abs(hitsLeft[i].point.x - transform.position.x);
        if (distance < 0.4f)
        {
            moveleft = true;
            nleft = hitsLeft[i].collider.gameObject;
        }

    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject GetNodeFromDirection(string direction)
    {
        if (direction =="Left"  && moveleft)
        {
            return nleft;
        }
        else if (direction == "Right" && moveright)
        {
            return nright;
        }
        else if (direction == "up" && moveup)
        {
            return nup;
        }
        else if (direction == "down" && movedown)
        {
            return ndown;
        }
        else        
        {
            return null;
        }
    }
}
