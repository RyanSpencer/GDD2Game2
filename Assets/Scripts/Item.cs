﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public enum type
    {
        CANDLE,
        DOOR,
        MATCHES
    };
    public type itemType;
    public GameObject myUserObject;
    public MyUser myUserScript;
    public Text userText;
    public GameObject invObj;
    public InventoryManager inventory;
    protected bool inInventory;
    public bool isHoldable;

	// Use this for initialization
	void Start () {
        Debug.Log("started");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void init()
    {
        Debug.Log("Candle clicked");
        inInventory = false;
        myUserScript = myUserObject.GetComponent<MyUser>();
        userText = myUserScript.textElement.GetComponent<Text>();
        inventory = invObj.GetComponent<InventoryManager>();

    }

    protected virtual void OnMouseUp() {}
}
