using UnityEngine;

namespace snd
{
	public class TimeManager : SingletonPersistent<TimeManager>
	{
		public float slowdownLength = 2f;
		public bool slowDown;

		private void Update()
		{
			if(slowDown)
			{
				Time.timeScale -= (1f / slowdownLength) * Time.unscaledDeltaTime;
				Time.fixedDeltaTime = .02f * Time.timeScale;
			}
			else if(!slowDown)
			{
				Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
				Time.fixedDeltaTime = .02f * Time.timeScale;
			}

			Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
		}
	}
}
