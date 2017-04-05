using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Candle : Item, IPointerClickHandler
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
    public override void  OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Candle clicked");
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
