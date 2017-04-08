using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Item
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

    protected override void OnMouseUp()
    {
        if (isHoldable)
        {
            if (!inInventory)
            {
                inInventory = !inInventory;

                inventory.addItem(gameObject, "Door");

                Destroy(gameObject);
            }
        }
        else
        {
            if (myUserScript.candleIsLit)
            {
                userText.text = "You exit the room!\n" + userText.text;
            }
            else
            {
                userText.text = "It's too dark to see out there.\n" + userText.text;
            }
            myUserScript.selectedType = MyUser.type.NULL;
            myUserScript.selectedObj = null;
        }
    }
}
