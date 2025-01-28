using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class arm : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //while mouse is down
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); //set mouse position
            mouse.z = 0;

            //point towards mouse
            Vector2 direction = mouse - transform.position; 
            transform.up = direction;
        }


    }
}
