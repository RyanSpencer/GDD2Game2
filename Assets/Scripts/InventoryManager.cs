using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
    const int SLOTS = 10;
    private GameObject[] slotArray = new GameObject[SLOTS];
    private Vector2 pos;
    private int size;
    private bool[] occupied = new bool[SLOTS];

	// Use this for initialization
	void Start () {
        pos = new Vector2(-1.5f, 0.6f);
        for (int i = 0; i < SLOTS; i++)
        {
            occupied[i] = false;
        }
        int c = 0;
        foreach (Transform child in transform)
        {
            slotArray[c] = child.gameObject;
            c++;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addItem(Material itemMat)
    {
        /*
         * Apply material
         * Apply script
         * Set occupied
         */
        // for(int i = 0; i < SLOTS; i++)
        //{
        //    if(!occupied[i])
        //    {
        //        slotArray[i].GetComponent<Image>().material = itemMat;
        //    }
        //}
    }
}
