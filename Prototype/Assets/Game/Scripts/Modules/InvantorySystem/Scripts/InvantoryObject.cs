using UnityEngine;

using Game.Logics;

namespace Game.Objects
{
	[CreateAssetMenu(fileName = "InventoryItem", menuName = "Game/Inventory", order = 0)]
	public class InvantoryObject : ScriptableObject
	{
		public GameObject objectPrefab;
		public Sprite objectImage;
		public int quantity = 0;
		public InventoryItemLogic itemLogic;
		public string objectTooltip;
	}
}
