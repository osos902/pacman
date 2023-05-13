using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNodes : MonoBehaviour
{
    int numSpawn = 28;
    public float CurrentSpawn;
    public float SpawnSet = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        /*gameObject.name = "Node";
        return;
        if (gameObject.name == "Node")
        {
            CurrentSpawn = SpawnSet;
            for(int i = 0; i < numSpawn; i++)
            {
                GameObject clone = Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y + CurrentSpawn, 0), Quaternion.identity);
                CurrentSpawn += SpawnSet;
            }
        }*/
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
