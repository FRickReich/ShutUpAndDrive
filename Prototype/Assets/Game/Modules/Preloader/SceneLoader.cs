using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class SceneLoader
	{
		private class LoadingMonoBehavior : MonoBehaviour { }

		public enum Scene
		{
			GameScene,
			Loading,
			MainMenu
		};

		private static Action onLoaderCallback;
		private static AsyncOperation loadingAsyncOperation;
		private static float progress;

		public static void Load(Scene scene)
		{
			// SET THE LOADER CALLBACK ACTION TO LOAD THE TARGET SCENE
			onLoaderCallback = () =>
			{
				GameObject loadingGameObject = new GameObject("Loading Object");

				loadingGameObject.AddComponent<LoadingMonoBehavior>().StartCoroutine(LoadSceneAsync(scene));
			};

			SceneManager.LoadScene(Scene.Loading.ToString());
		}

		private static IEnumerator LoadSceneAsync(Scene scene)
		{
			yield return null;

			AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(scene.ToString());

			while (!asyncOperation.isDone)
			{
				progress = Mathf.Clamp(asyncOperation.progress / 0.9f, 0, 1f);
				yield return null;
			}
		}

		public static float GetLoadingProgress()
		{
			if (loadingAsyncOperation != null)
			{
				return loadingAsyncOperation.progress;
			}
			else
			{
				return 1f;
			}
		}

		public static void LoaderCallback()
		{
			// TRIGGERED AFTER FIRST UPDATE WICH LETS THE SCENE REFRESH
			// EXECUTE THE LOADER CALLBACK ACTION WHICH WILL LOAD THE TARGET SCENE
			if (onLoaderCallback != null)
			{
				onLoaderCallback();
				onLoaderCallback = null;
			}
		}
	}
}
