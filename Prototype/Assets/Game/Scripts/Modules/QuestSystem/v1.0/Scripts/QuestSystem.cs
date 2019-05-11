using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Base;

namespace Game.Modules
{
    [CreateAssetMenu(menuName = "Game/Manager/QuestManager")]
    [ExecuteInEditMode]
	public class QuestSystem : SingletonScriptableObject<QuestSystem>
	{
		public List<Quest> questList;

        void Awake()
        {
            Quest[] quests = Resources.FindObjectsOfTypeAll<Quest>();

            Debug.Log("hi");
            foreach (Quest quest in quests)
			{
				questList.Add(quest);
			}
        }

    }
}