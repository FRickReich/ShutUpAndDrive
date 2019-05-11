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

		public event Action<String, String> sendNotificationEvent;

		private void OnEnable()
    	{
        	Checkpoint.checkpointChangeEvent += ChangeCheckpoint;
			Teleporter.SceneChangeEvent += ChangeScene;
			InputManager.xboxButtonSelectEvent += PauseButtonPressed;
			PlayerManager.playerDiedEvent += GameOver;
	    }

    	private void OnDisable()
    	{
        	Checkpoint.checkpointChangeEvent -= ChangeCheckpoint;
			Teleporter.SceneChangeEvent -= ChangeScene;
			InputManager.xboxButtonSelectEvent -= PauseButtonPressed;
			PlayerManager.playerDiedEvent -= GameOver;
    	}

		private void Start()
		{	
			LoadGame();
		}

		private void Update()
		{
			this.stateManager.ExecuteStateUpdate();

			gameSpeed = Time.timeScale;
			gameTime = timer.elapsed;
		}

		public void ChangeCheckpoint(Checkpoint newCheckpoint)
		{
			this.currentCheckpoint = newCheckpoint;

			SaveGame();
		}

		public void PauseButtonPressed(bool doActivate)
		{
			if(doActivate)
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

		public void SaveGame()
		{
			if(!sentMessage)
			{
				sentMessage = true;
			}

			this.stateManager.ChangeState(new GameSaveState(
				stateManager, 
				currentCheckpoint.name,
				gameTime
			));

			PlayerPrefsPro.SetString("currentCheckpoint", currentCheckpoint.name);
			PlayerPrefsPro.SetFloat("gameTime", gameTime);

			PlayerPrefsPro.Save();
		}

		public void LoadGame()
		{
			this.stateManager.ChangeState(new GameLoadState(stateManager));
		}

		public void GameOver()
		{
			this.stateManager.ChangeState(new GameOverState(stateManager));
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

		public void CreateNotification(string headerText, string descriptionText)
		{
			if(sendNotificationEvent != null)
		{
			sendNotificationEvent(headerText, descriptionText);
		}
		}
	}
}
