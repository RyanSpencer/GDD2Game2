﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class objectInteraction : MonoBehaviour {


    private int mouseClicks = 0;
	// Use this for initialization
	void Start () {

        //textBox = textElement.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
        {
            mouseClicks++;
            //textBox.text = "Mouse was clicked " + mouseClicks + " times.";
            Ray clickRay = new Ray(Input.mousePosition, new Vector3(0.0f, 0.0f, 1.0f));
            RaycastHit clickRayHit;
            if (Physics.Raycast(clickRay, out clickRayHit, 20))
            {
                
            }
        }
	}
}
