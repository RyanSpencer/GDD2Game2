using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matches : Item
{

    // Use this for initialization
    void Start()
    {
        base.init();

        if (invObj != null) { inventory = invObj.GetComponent<InventoryManager>(); }
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void OnMouseUp()
    {
        if (isHoldable)
        {
            if (!inInventory)
            {
                inInventory = !inInventory;

                inventory.addItem(gameObject, "Matches");

                userText.text = "You picked up some matches!\n" + userText.text;

                Destroy(gameObject);
            }
        }
        else
        {

            switch (myUserScript.selectedType)
            {
                case MyUser.type.NULL:
                    myUserScript.selectedType = MyUser.type.MATCHES;
                    myUserScript.selectedObj = gameObject;
                    userText.text = "Selected: Matches\n" + userText.text;
                    break;
                case MyUser.type.CANDLE:
                    if (!myUserScript.selectedObj.GetComponent<Candle>().isLit)
                    {
                        myUserScript.selectedType = MyUser.type.NULL;
                        myUserScript.selectedObj.GetComponent<Candle>().LightCandle();
                        inventory.removeItem(invIndex, "Matches");
                        myUserScript.selectedObj = null;
                        userText.text = "You lit the candle!\n" + userText.text;
                    }
                    else
                    {
                        myUserScript.selectedType = MyUser.type.NULL;
                        myUserScript.selectedObj = null;
                        userText.text = "The candle is already lit.\n" + userText.text;
                    }
                    break;
                case MyUser.type.MATCHES:
                    myUserScript.selectedType = MyUser.type.NULL;
                    userText.text = "Deselected: Matches\n" + userText.text;
                    break;
                default:
                    userText.text = "Nothing interesting happens.\n" + userText.text;
                    break;
            }
        }
    }
}
