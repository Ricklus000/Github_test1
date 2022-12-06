using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    GameObject ThingToSpawn;

    [SerializeField]
    Transform spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(ThingToSpawn, spawnpoint.position, Quaternion.identity);
        }
        
    }
}
