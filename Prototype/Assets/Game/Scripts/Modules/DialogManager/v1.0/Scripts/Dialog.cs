using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "Dialog", menuName = "Game/Assets/Dialog", order = 0)]
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