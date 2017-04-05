using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyUser : MonoBehaviour {

    public GameObject textElement;
    private Text textBox;
    public GameObject invObj;
    public GameObject selected;
    private Item itemScript;
    public InventoryManager invScript;

	// Use this for initialization
	void Start () {
        selected = null;
        invScript = invObj.GetComponent<InventoryManager>();
        textBox = textElement.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
