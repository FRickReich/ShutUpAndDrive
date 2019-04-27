using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace snd
{
	public class LoadingSceneUI : MonoBehaviour
	{
		public Image progressBar;
		public TMP_Text loadingText;
		public TMP_Text progressText;
		public TMP_Text continueText;

		private void Update()
		{
			if (SceneLoader.GetLoadingProgress() < 1f)
			{
				progressText.text = SceneLoader.GetLoadingProgress().ToString();
			}
			else if (SceneLoader.GetLoadingProgress() == 1f)
			{
				loadingText.gameObject.SetActive(false);
				progressText.gameObject.SetActive(false);
				continueText.gameObject.SetActive(true);
			}

			progressBar.fillAmount = SceneLoader.GetLoadingProgress();
		}
	}
}
