using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject Player;
    public float a;
    public float b;
    public float c;
    Vector3 _offset;

    void Start()
    {
        _offset = new Vector3(a, b, c); // or whatever you need
    }

    void FixedUpdate()
    {
        transform.position = Player.transform.position + _offset;

    }
}
