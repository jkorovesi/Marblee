using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        PlayerController.setDeadToTrue();
    }
}
