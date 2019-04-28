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
		Invoke("Fix", .1f);

	}
	void Fix()
	{

		transform.GetChild(4).gameObject.SetActive(false);

	}

}
