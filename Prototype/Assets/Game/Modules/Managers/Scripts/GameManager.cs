using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace snd
{
	public class GameManager : SingletonPersistent<GameManager>
	{
		public Checkpoint currentCheckpoint;
		
		public float gameSpeed;
		public float gameTime;

		public SimpleTimer timer;

		public bool gamePaused;
		public bool debugMode;

		private bool sentMessage;

		private StateManager stateManager = new StateManager();

		private void Start()
		{	
			this.stateManager.ChangeState(new GameLoadState(stateManager));
		}

		private void Update()
		{
			this.stateManager.ExecuteStateUpdate();

			gameSpeed = Time.timeScale;
			gameTime = timer.elapsed;

			if(InputManager.Instance.xboxButtonSelect)
			{
				if(!gamePaused)
                {
                    gamePaused = true;
                }
                else if(gamePaused)
                {
                    gamePaused = false;
                }
			}
		}

		public void ChangeCheckpoint(Checkpoint newCheckpoint)
		{
			this.currentCheckpoint = newCheckpoint;

			this.stateManager.ChangeState(new GameSaveState(
				stateManager, 
				currentCheckpoint.name,
				gameTime
			));
		}

		public void SaveGame()
		{
			if(!sentMessage)
			{
				GameObject.Find("Create Notification").GetComponent<CreateNotification>().Create("test", "ok");

				sentMessage = true;
			}

			PlayerPrefsPro.SetString("currentCheckpoint", currentCheckpoint.name);
			PlayerPrefsPro.SetFloat("gameTime", gameTime);

			PlayerPrefsPro.Save();
		}

		public void LoadGame()
		{

		}

		public void PauseGame()
		{
			this.stateManager.ChangeState(new GamePausedState(stateManager));
		}

		public void RunGame()
		{
			sentMessage = false;
			
			this.stateManager.ChangeState(new GameRunningState(stateManager));
		}

		public void ChangeScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
