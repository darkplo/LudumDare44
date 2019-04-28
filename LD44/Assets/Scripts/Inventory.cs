using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
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
			return true;
		}
		else
			return false;
	}

	internal bool Contains(int v)
	{
		bool k = false;
		foreach (var item in slots)
		{
			if (item.typeObject == (invObjectsType)(v))
			{
				k = true;
			}
		}
		return k;
	}

	internal void Remove(int v)
	{
		slots.RemoveAt(0);
	}
}
