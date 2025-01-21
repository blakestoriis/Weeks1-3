using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class square : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 0.05f;
    public AnimationCurve jump;
    public float t;
    public bool timer;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        if (pos.x < -9 || pos.x > 9)
        {
            speed = speed * -1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.Evaluate(t);
            pos.y = jump.Evaluate(t);
            timer = true;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            timer = false;
        }

        if (timer == true)
        {
            t = 40;
        }

        if (timer == false)
        {
            t = 0;
        }

        transform.position = pos;


    }
}
