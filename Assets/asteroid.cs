using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class asteroid : MonoBehaviour
{
    

    ScoreManager scoremanager;
    // Start is called before the first frame update
    void Start()
    {
        scoremanager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (scoremanager.hp<=0)
        {
            transform.position += new Vector3(0, 0);
            Destroy(gameObject);
        }
        else
        {
            transform.position += new Vector3(0, -2 * Time.deltaTime);
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bas")
        {
            scoremanager.hp -= 1;
        }
    }
}

