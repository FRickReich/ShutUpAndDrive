using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.States;

namespace Game.Modules
{
	public class GameManager : Game.Base.SingletonPersistent<GameManager>
	{
		private StateMachine stateManager = new StateMachine();

		public enum PlayMode
		{
			CHARACTER,
			VEHICLE
		}

		public InputMaster controls;
		public CheckpointZone currentCheckpoint;
		public SimpleTimer timer;

		public float slowdownLength = 2f;
		public bool slowDown;

        public float gameSpeed;
		public float gameTime;

		public bool gamePaused;
		public bool debugMode;
		public bool firstRun;

		private void OnEnable()
		{
			CheckpointZone.checkpointChangeEvent += ChangeCheckpoint;
			
			InputMaster controls = new InputMaster();

			controls.Character.Menu.performed += context => SetGamePause();
            controls.Character.Options.performed += context => SetGamePause();
			
			controls.Enable();
		}

		private void OnDisable() 
		{
			CheckpointZone.checkpointChangeEvent -= ChangeCheckpoint;	
		}

		// Start is called before the first frame update
		void Start()
		{
            timer = new SimpleTimer();

			if(firstRun)
			{
				RunGame();
			}
			else
			{
				LoadGame();
			}
		}

		// Update is called once per frame
		void Update()
		{
			this.stateManager.ExecuteStateUpdate();

            gameSpeed = Time.timeScale;
			gameTime = timer.elapsed;

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

		public void ChangeCheckpoint(CheckpointZone newCheckpoint)
		{
			this.currentCheckpoint = newCheckpoint;

			// SAVE GAME
		}

		public void SaveGame()
		{

		}

		public void LoadGame()
		{

		}

		public void RunGame()
		{
			this.stateManager.ChangeState(new GameRunningState(stateManager));
		}

		public void PauseGame()
		{
			this.stateManager.ChangeState(new GamePauseState(stateManager));
		}

		public void SetGamePause()
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
}
