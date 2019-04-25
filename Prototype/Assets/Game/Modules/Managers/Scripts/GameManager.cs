using UnityEngine;
using UnityEngine.SceneManagement;

namespace snd
{
	public class GameManager : SingletonPersistent<GameManager>
	{
		public Checkpoint currentCheckpoint;
		private float gameTime;

		private StateManager stateManager = new StateManager();

		private void Start()
		{
			this.stateManager.ChangeState(new GameLoadState(stateManager));
		}

		private void Update()
		{
			this.stateManager.ExecuteStateUpdate();

			Debug.Log(PlayerPrefs.GetString("currentCheckpoint"));
		}

		public void ChangeCheckpoint(Checkpoint newCheckpoint)
		{
			currentCheckpoint = newCheckpoint;

			SaveGame();
		}

		public void SaveGame()
		{
			Debug.Log("Saving Game");

			PlayerPrefs.SetString("currentCheckpoint", currentCheckpoint.name);
		}

		public void LoadGame()
		{

		}

		public void GameOver()
		{
			
		}

		public void PauseGame(bool isPaused)
		{
			//if(isPaused)
			//{
			//	//this.stateManager.ChangeState(new GamePausedState(stateManager));
			//}
			//else
			//{
			//	//this.stateManager.ChangeState(new GameRunningState(stateManager));
			//}
		}

		public void ChangeScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
