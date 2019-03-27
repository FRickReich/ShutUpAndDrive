using UnityEngine;
using UnityEngine.Events; 

using Game.Modules;

namespace Game.Modules.TimerSystem
{
	public class Timer : MonoBehaviour
	{
		public float countdown = 5;
		public bool runOnAwake = true;
		public bool loop = true;

		public UnityEvent onTimerEnd;

		private void OnEnable()
		{
			if(runOnAwake)
			{
				Invoke("Execute", 0);
			}

			if(loop)
			{
				InvokeRepeating("Execute", countdown, countdown);
			}
			else
			{
				Invoke("Execute", countdown);
			}
		}

		private void Execute()
		{
			onTimerEnd.Invoke();
		}
	}
}