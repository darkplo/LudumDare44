using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryViewer : MonoBehaviour
{
	public List<Image> invSlots;
	Inventory inventory;
	private void Start()
	{
		inventory = FindObjectOfType<Inventory>();
		inventory.Register(this);
		foreach (Transform child in transform)
		{

		}
	}

}
