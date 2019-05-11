using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Game.Modules
{
	[System.Serializable]
	[CreateAssetMenu(fileName = "Quest", menuName = "Game/Assets/Quest", order = 0)]
	public class Quest : ScriptableObject
	{
		public enum QuestStatus
    	{
        	LOCKED,                             // LOCKED (AVAILIBLE LATER OR GONE)
        	AVAILABLE,                          // QUEST IS AVAILIBLE TO BE STARTED
        	ACTIVE,                             // QUEST HAS BEEN ACTIVATED BUT NOT COMPLETED
        	COMPLETE,                           // QUEST HAS BEEN COMPLETED BUT NOT CLOSED
        	DONE                                // QUEST HAS BEEN CLOSED (BROUGHT BACK TO NPC/FULFILLED?)
    	}

        public string title;					// String Title for the quest
	    public int id;							// ID number for the quest                
	    public QuestStatus progress;			// State of the current quest progress (enum)
	    public string description;				// String from the Quest Giver/Receiver
	    public string hint;						// String from the Quest Giver/Receiver
	    public string congratulations;			// String from the Quest Giver/Receiver
	    public string summary;					// String from the Quest Giver/Receiver
	    public int nextQuest;					// The next quest, if there is one (chain quests)
	    public string questObjective;			// Name of the item / you can always change it to int, to use int ID's instead of names
	    public int questObjectiveCount;			// Current number of questObjective Objects
	    public int questObjectiveRequirement;	// Required amount of questObjective Objects

    	public int expReward;                   // REWARD IN EXPERIENCE
	    public int goldReward;                  // REWARD IN GOLD
	    public string itemReward;               // REWARD IN ITEMS
	}
}
