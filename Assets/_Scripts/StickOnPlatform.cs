using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickOnPlatform : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //player.transform.parent = this.transform;
        GameObject emptyObject = new GameObject();
        emptyObject.transform.parent = this.transform;
        player.transform.parent = emptyObject.transform;

    }

    private void OnTriggerExit(Collider other)
    {
        transform.DetachChildren();
    }
}
