using UnityEngine;
using UnityEngine.SceneManagement;

namespace snd
{
	public class GameStateManager : SingletonPersistent<GameStateManager>
	{
		public int credits = 250;

		public float gameTime = 0;

		private void Start()
		{
			
		}

		public void AddCredits(int amount)
		{
			credits += amount;
		}

		public void PauseGame(bool isPaused)
		{
			if(isPaused)
			{
				Debug.Log("Game Paused");
			}
			else
			{
				Debug.Log("Game Running");
			}
		}

		public void ChangeScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}