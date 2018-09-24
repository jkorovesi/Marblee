﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour {

    public Text timer;
    public float seconds, minutes;


	// Use this for initialization
	void Start () {
        //timer = GetComponent<Text>() as Text;	
	}
	
	// Update is called once per frame
	void Update () {
        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        timer.text = "Timer: " + minutes.ToString("00") + ":" + seconds.ToString("00");
	}
}