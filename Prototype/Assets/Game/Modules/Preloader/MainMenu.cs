using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace snd
{
	public class MainMenu : MonoBehaviour
	{
		public Button mainMenuBTN;

		private void Awake()
		{
			mainMenuBTN.onClick.AddListener(() =>
			{
				Debug.Log("Test");
				SceneLoader.Load(SceneLoader.Scene.GameScene);
			});
		}
	}
}
