using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.V1.Dialog;

namespace Game.V1.Object
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