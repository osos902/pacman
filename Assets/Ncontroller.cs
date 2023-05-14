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



}



    // Start is called before the first frame update
    void Start()
    { 
        RayCastHit2D[] hitsDown;
    // for shooting 3lshan unzel down  
        hitsDown = physics2d.RayCastAll(transfrom.position, -vector2.up);
    // loop through el l3b objects
        for (int i = 0;i<hitsDown.legnth;i++) {
        float distance = Mathf.Abs(hitsDown[i].point.y - transform.position.y);
        if (distance < 0.4f)
            {
            movedown = true;
            ndown = hitsDown[i].colider.gameObject;
            }
    
        }
         RayCastHit2D[] hitsUp;
         // for shooting 3lshan unzel down  
         hitsUp = physics2d.RayCastAll(transfrom.position, -vector2.up);
    // loop through el l3b objects
    for (int i = 0; i < hitsUp.legnth; i++)
    {
        float distance = Mathf.Abs(hitsUp[i].point.y - transform.position.y);
        if (distance < 0.4f)
        {
            moveup = true;
            nup = hitsUp[i].colider.gameObject;
        }

    }
    RayCastHit2D[] hitsRight;
    // for shooting 3lshan unzel  
    hitsRight = physics2d.RayCastAll(transfrom.position, -vector2.Right);
    // loop through el l3b objects
    for (int i = 0; i < hitsRight.legnth; i++)
    {
        float distance = Mathf.Abs(hitsRight[i].point.x - transform.position.x);
        if (distance < 0.4f)
        {
            moveright = true;
            nright = hitsRight[i].colider.gameObject;
        }

    }
    RayCastHit2D[] hitsLeft;
    // for shooting 3lshan unzel down  
    hitsLeft = physics2d.RayCastAll(transfrom.position, -vector2.up);
    // loop through el l3b objects
    for (int i = 0; i < hitsLeft.legnth; i++)
    {
        float distance = Mathf.Abs(hitsLeft[i].point.x - transform.position.x);
        if (distance < 0.4f)
        {
            moveleft = true;
            nleft = hitsLeft[i].colider.gameObject;
        }

    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
