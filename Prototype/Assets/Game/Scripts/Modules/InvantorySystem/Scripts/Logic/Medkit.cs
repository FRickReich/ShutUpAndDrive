using UnityEngine;

namespace Game.Logics
{
	public class Medkit : RuntimeInventoryLogic
	{

		public float healAmount = 25;

		public override void Use(GameObject player)
		{
			player.GetComponent<ExampleHealth>().Health += healAmount;
		}
	}
}
