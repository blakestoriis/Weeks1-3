using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Sky : MonoBehaviour
{
    public Vector2 start;
    public Vector2 end;

    public float layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // sets mouse position
        transform.position = Vector2.Lerp(start, end, mousePos.x/16 + 0.5f); // lerp maps the start and end and the mouse controls moving from start to end


        Vector3 pos = transform.position;
        pos.z = layer; //sets layer

        transform.position = pos;
    }
}
