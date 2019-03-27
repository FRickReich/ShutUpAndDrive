using UnityEngine;

using Game.Modules;

namespace Game.Modules.TimerSystem
{
	public class Destroyer : MonoBehaviour
	{
		public void Destroy()
		{
			Destroy(gameObject);
		}
	}
}