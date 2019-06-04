using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Managers;

namespace Game.Objects
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Dialog", menuName = "Game/Dialog", order = 0)]
    public class Dialog : ScriptableObject
    {
        public string identifier;
        public DialogLine[] lines;

        public void Callback()
        {
            Debug.Log("Callback...");
        }
    }
}