using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Base;
using Game.Objects;

namespace Game.Modules
{
    [CreateAssetMenu(menuName = "Game/Manager/QuestManager")]
    [ExecuteInEditMode]
	public class QuestSystem : SingletonScriptableObject<QuestSystem>
	{
		public List<Game.Objects.Quest> questList;

        void Awake()
        {
            Game.Objects.Quest[] quests = Resources.FindObjectsOfTypeAll<Game.Objects.Quest>();

            Debug.Log("hi");
            foreach (Game.Objects.Quest quest in quests)
			{
				questList.Add(quest);
			}
        }

    }
}