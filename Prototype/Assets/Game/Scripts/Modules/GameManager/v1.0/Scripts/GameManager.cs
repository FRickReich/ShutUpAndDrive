using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Events;
using Game.States;
using Game.Enums;

namespace Game.Modules
{
	public class GameManager : Game.Base.SingletonPersistent<GameManager>
	{
		private StateMachine stateMachine = new StateMachine();

		public InputMaster controls;
		public CheckpointZone currentCheckpoint;
		public SimpleTimer timer;

		public GameplayMode currentGameplayMode;

		public GameObject playerCharacterPrefab;

		public GameObject player;

		public float slowdownLength = 2f;
		public bool slowDown;

        public float gameSpeed;
		public float gameTime;

		public bool gamePaused;
		public bool debugMode;
		public bool firstRun;

		public static event Action<bool> setDebugModeEvent;
		public VoidEvent activateDebugMode;
		public VoidEvent deactivateDebugMode;

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
				this.stateMachine.ChangeState(new NewGameState(stateMachine));
			}
			else
			{
				this.stateMachine.ChangeState(new GameLoadingState(stateMachine));
			}
		}

		// Update is called once per frame
		void Update()
		{
			this.stateMachine.ExecuteStateUpdate();

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

			if(debugMode == true)
			{
				activateDebugMode.Raise();
			}
			else if(debugMode == false)
			{
				deactivateDebugMode.Raise();
			}

			Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
		}

		public void ChangeCheckpoint(CheckpointZone newCheckpoint)
		{
			this.currentCheckpoint = newCheckpoint;

			// SAVE GAME
		}

		public void SaveGame() {}

		public void LoadGame()
		{
			this.stateMachine.ChangeState(new GameLoadingState(
				stateMachine
			));
		}

		public void RunGame()
		{
			this.stateMachine.ChangeState(new GameRunningState(stateMachine));
		}

		public void PauseGame()
		{
			this.stateMachine.ChangeState(new GamePauseState(stateMachine));
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

		public void AttachCameraToPlayer() {}

		public void SpawnPlayer()
		{
			player = Instantiate(playerCharacterPrefab, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
		}
	}
}
