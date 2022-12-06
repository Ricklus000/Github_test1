using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class skott : MonoBehaviour
{
    ScoreManager scoreManager;
  
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
       transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            Destroy(collision.gameObject);
            scoreManager.score += 5;
        }
        if (collision.gameObject.tag == "healthpack")
        {
            Destroy(collision.gameObject);
            scoreManager.hp += 1;
        }




    }

   
}
