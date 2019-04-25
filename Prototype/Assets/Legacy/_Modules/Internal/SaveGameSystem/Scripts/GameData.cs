using UnityEngine;

using Game.Modules;
using Game.Modules.Internal;

namespace Game.Modules.Internal
{
	[System.Serializable]
	public class GameData
	{
		public int level;
		public int health;
		public float[] position;

		public GameData(GameManager gameManager)
		{
			level = 20;
			health = 20;
			position = new float[3];
			position[0] = gameManager.transform.position.x;
			position[1] = gameManager.transform.position.y;
			position[2] = gameManager.transform.position.z;
		}
	}
}