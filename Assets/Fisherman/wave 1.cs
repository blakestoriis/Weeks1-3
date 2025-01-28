using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class wave1 : MonoBehaviour
{
    public AnimationCurve wavex; //animation curve for x value
    public AnimationCurve wavey; //animation curve for y value


    [Range(0, 1)]
    public float t = 0;

    public float layer;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }

        Vector3 pos = transform.position;

        pos.x = wavex.Evaluate(t); //x axis moves according to the animation curve
        pos.y = wavey.Evaluate(t); //y axis moves according to the animation curve
        pos.y = pos.y + y;//updates position
        pos.z = layer; //sets layer

        transform.position = pos;

    }
}
