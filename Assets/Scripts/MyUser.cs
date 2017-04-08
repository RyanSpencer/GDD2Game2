using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyUser : MonoBehaviour {
    public enum type
    {
        NULL,
        CANDLE,
        DOOR,
        MATCHES
    };
    public type selectedType = type.NULL;
    public GameObject selectedObj;
    public GameObject textElement;
    private Text textBox;
    public GameObject invObj;
    private Item itemScript;
    public InventoryManager invScript;
    public bool candleIsLit = false;

	// Use this for initialization
	void Start () {
        invScript = invObj.GetComponent<InventoryManager>();
        textBox = textElement.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
