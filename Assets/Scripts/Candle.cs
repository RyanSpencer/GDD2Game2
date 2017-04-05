using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : Item
{

    private bool isLit;

    // Use this for initialization
    void Start () {
        base.init();
        isLit = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void LightCandle()
    {

    }

    protected override void OnMouseUp()
    {
        //Debug.Log("Candle clicked");
        if (isHoldable)
        {
            if (!inInventory)
            {
                inInventory = !inInventory;
                //GameObject candle = this.GetComponent<GameObject>();
                inventory.addItem(gameObject.GetComponent<Material>());
                Destroy(gameObject);
            }
        }

        switch (myUserScript.selected.GetComponent<Item>().itemType)
        {
            case type.MATCHES:
                userText.text += "\nYou lit the candle!";
                LightCandle();
                break;
            default:
                userText.text += "\nNothing interesting happens.";
                break;
        }
    }
}
