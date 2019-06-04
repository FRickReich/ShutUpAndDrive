using UnityEngine;

using Game.Objects;

public enum LogicType
{
	Spawn,
	Other
}

namespace Game.Logics
{
	[System.Serializable]
	public class InventoryItemLogic
	{
		public LogicType logicType;
		public string name;

		public void UseItem(Transform tf, InvantoryObject invantoryObject)
		{
			switch (logicType)
			{
				case LogicType.Spawn:
					Object.Instantiate(invantoryObject.objectPrefab, tf.position + (tf.forward * 2), Quaternion.identity);
					break;
				case LogicType.Other:
					invantoryObject.objectPrefab.GetComponent<RuntimeInventoryLogic>().Use(tf.gameObject);
					break;
				default:
					break;
			}
		}
	}
}
