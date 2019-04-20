using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameToolkit.Localization;

public class QuestIngameUI : MonoBehaviour
{
    public Text currentQuestTitle;
    public Text currentQuestDescription;

    // Start is called before the first frame update
    void Start()
    {
        currentQuestTitle.text = "";
        currentQuestDescription.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        var questTitle = Localization.FindAllLocalizedAssets().Length;
        var quests = Localization.FindAllLocalizedAssets();
        var currentQuest = 0;

        int itemToSelect = 0;

        if (Localization.Instance.CurrentLanguage == SystemLanguage.English)
        {
            itemToSelect = 0;
        }
        else if (Localization.Instance.CurrentLanguage == SystemLanguage.German)
        {
            itemToSelect = 1;
        }

        foreach (var quest in quests)
        {
            if(quest.name == "Quest " + currentQuest +" - Title")
            {
                currentQuestTitle.text = quest.LocaleItems[itemToSelect].ObjectValue.ToString();
            }
        }

        if (QuestManager.questManager.currentQuestList.Count > 0)
        {
            string currentStatus = QuestManager.questManager.currentQuestList[0].questObjective;
            string questDescription = "";
            string questCounter = "";
            string currentProgress = "";

            if (QuestManager.questManager.currentQuestList[0].progress != Quest.QuestProgress.DONE)
            {
                if (QuestManager.questManager.currentQuestList[0].progress == Quest.QuestProgress.COMPLETE)
                {
                    currentProgress = "* ";
                }

                if (QuestManager.questManager.currentQuestList[0].questType == Quest.QuestType.COUNTED)
                {
                    questCounter = ": " + QuestManager.questManager.currentQuestList[0].questObjectiveCount + " / " + QuestManager.questManager.currentQuestList[0].questObjectiveRequirement;

                    questDescription = currentStatus + questCounter;
                }
                else
                {
                    questDescription = QuestManager.questManager.currentQuestList[0].summary;
                }

                currentQuestDescription.text = currentProgress + questDescription; 
            }
        }
        else
        {
            currentQuestTitle.text = "";
            currentQuestDescription.text = "";
        }
    }
}
