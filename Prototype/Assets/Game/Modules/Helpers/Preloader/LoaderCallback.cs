using UnityEngine;

namespace snd
{
	public class LoaderCallback : MonoBehaviour
	{
		private bool isFirstUpdate = true;

		private void Update()
		{
			if (isFirstUpdate)
			{
				isFirstUpdate = false;

				if(InputManager.Instance.xboxButtonA)
				{
					SceneLoader.LoaderCallback();
				}
			}
		}
	}
}