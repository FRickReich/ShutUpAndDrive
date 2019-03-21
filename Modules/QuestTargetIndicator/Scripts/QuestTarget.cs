using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.QuestTargetSystem
{
    public enum QuestType
    {
        MAINQUEST,
        SIDEQUEST
    }

    public class QuestTarget : MonoBehaviour
    {
        public QuestType questType;
    }
}