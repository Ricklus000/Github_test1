using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawner : MonoBehaviour
{
    [SerializeField]
    GameObject ThingToSpawn;
    [SerializeField]
    GameObject ThingToSpawn2;
    

    ScoreManager scoremanager;

    float timer = 0;
    float timer2 = 60;
    float timer3 = 120;
    float htimer = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(ThingToSpawn, new Vector3(Random.Range(-11,11), 5.5f), Quaternion.identity);
            timer = Random.Range(2,5);
        }
        timer2 -= Time.deltaTime;
        if (timer2 <= 0)
        {
            timer += 9999999999;
            Instantiate(ThingToSpawn, new Vector3(Random.Range(-11, 11), 5.5f), Quaternion.identity);
            timer2 = Random.Range(2, 3);
        }
        timer3 -= Time.deltaTime;
        if (timer3 <= 0)
        {
            timer2 += 9999999999;
            Instantiate(ThingToSpawn, new Vector3(Random.Range(-11, 11), 5.5f), Quaternion.identity);
            timer3 = 1;
        }
        htimer -= Time.deltaTime;
        if (htimer<=0)
        {
            Instantiate(ThingToSpawn2, new Vector3(Random.Range(-11, 11), 5.5f), Quaternion.identity);
            htimer += 30;
        }
        
       

    }
}
