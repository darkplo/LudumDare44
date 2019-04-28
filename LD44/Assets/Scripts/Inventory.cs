using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	InventoryViewer invViewer;
	List<InvObject> slots;
	int maxOb = 5;
    // Start is called before the first frame update
    void Start()
    {
		slots = new List<InvObject>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public bool PickUp(InvObject ob)
	{
		if (slots.Count < maxOb)
		{
			slots.Add(ob);
			invViewer.invSlots[slots.Count-1].sprite = ob.sprite;
			return true;
		}
		else
			return false;
	}
	internal void Register(InventoryViewer inventoryViewer)
	{
		invViewer = inventoryViewer;
	}
}
