﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : Item
{
    public bool isLit;

    // Use this for initialization
    void Start () {
        base.init();
        isLit = false;

        if (invObj != null) { inventory = invObj.GetComponent<InventoryManager>(); }
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void LightCandle()
    {
        isLit = true;
        myUserScript.candleIsLit = true;
    }

    protected override void OnMouseUp()
    {
        if (isHoldable)
        {
            if (!inInventory)
            {
                inInventory = !inInventory;

                inventory.addItem(gameObject, "Candle");

                userText.text = "You picked up a candle!\n" + userText.text;

                Destroy(gameObject);
            }
        }
        else
        {

            switch (myUserScript.selectedType)
            {
                case MyUser.type.NULL:
                    myUserScript.selectedType = MyUser.type.CANDLE;
                    myUserScript.selectedObj = gameObject;
                    userText.text = "You selected the candle!\n" + userText.text;
                    break;
                case MyUser.type.CANDLE:
                    myUserScript.selectedType = MyUser.type.NULL;
                    myUserScript.selectedObj = null;
                    userText.text = "Candle no longer selected!\n" + userText.text;
                    break;
                case MyUser.type.MATCHES:
                    if (!isLit)
                    {
                        myUserScript.selectedType = MyUser.type.NULL;
                        myUserScript.selectedObj = null;
                        userText.text = "You lit the candle!\n" + userText.text;
                        LightCandle();
                    }
                    else
                    {
                        myUserScript.selectedType = MyUser.type.NULL;
                        myUserScript.selectedObj = null;
                        userText.text = "The candle is already lit!\n" + userText.text;
                    }
    
                    break;
                default:
                    userText.text = "Nothing interesting happens.\n" + userText.text;
                    break;
            }
        }
    }
}
