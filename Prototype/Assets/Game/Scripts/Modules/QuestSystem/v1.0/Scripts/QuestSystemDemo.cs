using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using Game.Objects;

namespace Game.Test
{
	public class QuestSystemDemo : MonoBehaviour
	{
        public QuestManager questManager;

		// Start is called before the first frame update
		void Start()
		{
			Game.Objects.Quest[] quests;

            quests = Resources.FindObjectsOfTypeAll<Game.Objects.Quest>();

			foreach (Game.Objects.Quest quest in quests)
			{
				Debug.Log(quest.description);
			}
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}
