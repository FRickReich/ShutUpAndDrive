using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;

namespace Game.Modules.QuestTargetSystem
{
    public enum QuestType
    {
        MAINQUEST,
        SIDEQUEST,
        HOME
    }

    public class QuestTarget : MonoBehaviour
    {
        public QuestType questType;
    }
}