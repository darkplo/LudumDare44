using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Create Object", order=0)]
public class InvObject : ScriptableObject
{
	public invObjectsType typeObject;
	public Sprite sprite;

	public void Use()
	{
		switch (typeObject)
		{
			case invObjectsType.defibrillator:
				break;
			case invObjectsType.perfusionTube:
				break;
			case invObjectsType.drug:
				break;
			case invObjectsType.vaccine:
				break;
			default:
				break;
		}
	}
}
public enum invObjectsType
{
	defibrillator,
	perfusionTube,
	drug,
	vaccine
}