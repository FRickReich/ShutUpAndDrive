using UnityEngine;
using UnityEngine.UI;

namespace Game.V1.Dialog
{   
	[System.Serializable]
    public class DialogLine
    {
        [SerializeField]
		public Game.Objects.Character speaker;
		public Sprite portrait;
		
		[SerializeField]
		[TextArea(3, 10)]
		public string sentence;
	}
}