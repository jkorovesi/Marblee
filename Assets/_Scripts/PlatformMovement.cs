using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    public float speed;
    public float theLength;

    public Vector3 pointA;
    public Vector3 pointB;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, theLength);
        transform.position = Vector3.Lerp(pointA, pointB, time);
        //if(transform.position == pointA)
        //{
        //    transform.position = Vector3.Lerp(pointA, pointB, speed * Time.deltaTime);
        //}

    }
}
