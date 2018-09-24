using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickOnPlatform : MonoBehaviour {

    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        GameObject emptyObject = new GameObject();
        emptyObject.transform.parent = this.transform;
        player.transform.parent = emptyObject.transform;

        //if(other.gameObject == player)
        //{
        //    player.transform.parent = transform;
        //}

    }

    private void OnTriggerExit(Collider other)
    {
        transform.DetachChildren();
        //player.transform.parent = null;
    }
}
