using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Game.Modules.Internal
{
	public static class SaveSystem
	{
		public static void SaveCurrent(GameManager gameManager)
		{
			BinaryFormatter formatter = new BinaryFormatter();

			string path = Application.persistentDataPath + "/saveGame.sgm";

			FileStream stream = new FileStream(path, FileMode.Create);

			GameData data = new GameData(gameManager);

			formatter.Serialize(stream, data);
			stream.Close();
		}

		public static GameData LoadPlayer()
		{
			string path = Application.persistentDataPath + "/saveGame.sgm";

			if(File.Exists(path))
			{
				BinaryFormatter formatter = new BinaryFormatter();

				FileStream stream = new FileStream(path, FileMode.Open);

				GameData data = formatter.Deserialize(stream) as GameData;
				stream.Close();

				return data;
			}
			else
			{
				Debug.LogError("Save file not found.");
				return null;
			}
		}
	}
}