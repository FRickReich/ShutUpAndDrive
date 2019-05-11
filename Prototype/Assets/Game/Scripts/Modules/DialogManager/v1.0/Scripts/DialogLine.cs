using UnityEngine;

namespace Game.Modules
{   
	[System.Serializable]
    public class DialogLine
    {
        [SerializeField]
		public string speaker;
		
		[SerializeField]
		[TextArea(3, 10)]
		public string sentence;
	}
}