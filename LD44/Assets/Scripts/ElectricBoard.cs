using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBoard : MonoBehaviour
{
	public PlayerTeleportation tp;
	Inventory inv;
	BoxCollider2D m_collider;
	private bool isColliding;
	private Collider2D objectColliding;
	// Start is called before the first frame update
	void Start()
	{
		isColliding = false;
		m_collider = GetComponent<BoxCollider2D>();
		inv = FindObjectOfType<Inventory>();
		
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (isColliding)
		{
			InputsManager iPlayer = objectColliding.GetComponent<InputsManager>();
			if (iPlayer == null)
				return;
			if (iPlayer.interract)
			{
				iPlayer.interract = false;
				if (inv.Contains(0))
				{
					tp.enabled = true;
					Debug.Log("ASCENSEURRRE !!ds!q!ds!");
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		InputsManager iPlayer = col.GetComponent<InputsManager>();
		if (iPlayer != null)
		{
			iPlayer.p_up = false;
			iPlayer.p_down = false;
			iPlayer.interract = false;
			isColliding = true;
			objectColliding = col;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		isColliding = false;
		objectColliding = null;
	}
}
