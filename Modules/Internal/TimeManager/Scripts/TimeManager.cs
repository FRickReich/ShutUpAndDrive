using UnityEngine;

namespace Game.Modules.Internal
{
	public class TimeManager : MonoBehaviour
	{
		public float slowDownFactor = 0.05f;
		public float slowDownLength = 2.0f;

		private void Update()
		{
			Time.timeScale += (1f / slowDownLength) * Time.unscaledDeltaTime;
			Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
		}

		void StartTimeSlowDown()
		{
			Time.timeScale = slowDownFactor;
			Time.fixedDeltaTime = Time.timeScale * .2f;
		}
	}
}