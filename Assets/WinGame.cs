using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        PlayerController.setYouWinToTrue();
    }
}
