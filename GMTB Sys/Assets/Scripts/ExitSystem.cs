﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Closing system ");
            Application.Quit();
        }
    }
}
