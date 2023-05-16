using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource serin;
    public GameObject leftWarpNode;
    public GameObject rightWarpNode;
    // Start is called before the first frame update
    void Awake()
    {
        serin.Play();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
