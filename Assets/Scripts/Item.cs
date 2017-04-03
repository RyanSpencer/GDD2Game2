using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerClickHandler
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
    public GameObject inventory;
    protected bool inInventory;

	// Use this for initialization
	void Start () {
        Debug.Log("started");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void init()
    {
        inInventory = false;
        myUserScript = myUserObject.GetComponent<MyUser>();
        userText = myUserScript.textElement.GetComponent<Text>();
    }
    public virtual void OnPointerClick(PointerEventData eventData) { }
    
}
