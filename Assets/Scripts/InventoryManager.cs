using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
    const int SLOTS = 10;
    private SpriteRenderer[] slotSprites = new SpriteRenderer[SLOTS];
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

    public void removeItem(int index, string itemToDestroy)
    {

        switch (itemToDestroy)
        {
            case "Matches":
                Destroy(slotArray[index].GetComponent<Matches>());
                slotArray[index].GetComponent<SpriteRenderer>().sprite = null;
                break;
            case "Candle":
                Destroy(slotArray[index].GetComponent<Candle>());
                slotArray[index].GetComponent<SpriteRenderer>().sprite = null;
                break;
        }
    }
    public void changeSlotSprite(int index, Sprite newSprite)
    {
        Sprite oldSprite = slotArray[index].GetComponent<SpriteRenderer>().sprite;
        slotArray[index].GetComponent<SpriteRenderer>().sprite = Sprite.Create(newSprite.texture, oldSprite.rect, new Vector3(0.5f, 0.5f), 5);
    }

    public void addItem(GameObject item, string itemType)
    {
        /*
         * Apply material
         * Apply script
         * Set occupied
         */
        for (int i = 0; i < SLOTS; i++)
        {
            if (!occupied[i])
            {    
                Sprite sp = item.GetComponent<SpriteRenderer>().sprite;
                //Create a new sprite using the old image and rectangle but it needs a new pivot beacuse the old one was broken, change the last value to change size, the smaller the bigger
                slotArray[i].GetComponent<SpriteRenderer>().sprite = Sprite.Create(sp.texture, sp.rect, new Vector3(0.5f, 0.5f), 5);
                switch (itemType)
                {
                    case "Candle":
                        slotArray[i].AddComponent<Candle>();
                        slotArray[i].GetComponent<Candle>().inInventory = true;
                        slotArray[i].GetComponent<Candle>().myUserObject = item.GetComponent<Item>().myUserObject;
                        slotArray[i].GetComponent<Candle>().userText = item.GetComponent<Item>().userText;
                        slotArray[i].GetComponent<Candle>().invObj = item.GetComponent<Item>().invObj;
                        slotArray[i].GetComponent<Candle>().inventory = item.GetComponent<Item>().invObj.GetComponent<InventoryManager>();
                        slotArray[i].GetComponent<Candle>().invIndex = i;
                        break;
                    case "Matches":
                        slotArray[i].AddComponent<Matches>();
                        slotArray[i].GetComponent<Matches>().inInventory = true;
                        slotArray[i].GetComponent<Matches>().myUserObject = item.GetComponent<Item>().myUserObject;
                        slotArray[i].GetComponent<Matches>().userText = item.GetComponent<Item>().userText;
                        slotArray[i].GetComponent<Matches>().invObj = item.GetComponent<Item>().invObj;
                        slotArray[i].GetComponent<Matches>().inventory = item.GetComponent<Item>().invObj.GetComponent<InventoryManager>();
                        slotArray[i].GetComponent<Matches>().invIndex = i;
                        break;
                }

                occupied[i] = true;
                break;

            }
        }
    }
}
