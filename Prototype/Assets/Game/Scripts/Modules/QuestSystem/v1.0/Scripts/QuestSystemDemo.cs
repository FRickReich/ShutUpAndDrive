using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using QuestCall = Game.Modules.Quest;

namespace Game.Test
{
	public class QuestSystemDemo : MonoBehaviour
	{
        public QuestManager questManager;

		// Start is called before the first frame update
		void Start()
		{
			QuestCall[] quests;

            quests = Resources.FindObjectsOfTypeAll<QuestCall>();

			foreach (QuestCall quest in quests)
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
