using UnityEngine;

namespace Game
{
	public class QuestTargetController : MonoBehaviour
	{

		public Animator animator;

		public void HandleNotification(bool value)
		{
			animator.SetBool("ShowIndicator", value);
		}
	}
}
