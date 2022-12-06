using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rymdskepp:MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position=new Vector3( Mathf.Clamp(transform.position.x,-11.45f,11.45f), -3.5f, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-10, 0, 0)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(10, 0, 0)*Time.deltaTime;
        }
    }
}
