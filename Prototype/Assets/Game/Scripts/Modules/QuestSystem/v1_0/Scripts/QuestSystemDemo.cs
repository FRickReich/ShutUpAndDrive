using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using QuestSystemModule = Game.Modules.QuestSystem.v1_0;

namespace Game.Test
{
	public class QuestSystemDemo : MonoBehaviour
	{
        public QuestSystemModule.QuestManager questManager;

		
        
		// Start is called before the first frame update
		void Start()
		{
			QuestSystemModule.Quest[] quests;

            quests = Resources.FindObjectsOfTypeAll<QuestSystemModule.Quest>();

			foreach (QuestSystemModule.Quest quest in quests)
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
