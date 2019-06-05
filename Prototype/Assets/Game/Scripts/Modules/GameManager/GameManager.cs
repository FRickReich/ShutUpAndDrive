using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Helpers;
using Game.States;
using Game.Zones;

namespace Game.Managers
{
	public class GameManager : Game.Base.SingletonPersistent<GameManager>
	{
		public event Action<String, String> sendNotificationEvent;

		private StateManager stateManager = new StateManager();
		private SimpleTimer gameTimer;

		public InputControls inputControls;

		public GameObject playerCharacterPrefab;
		public GameObject CameraManager;
		public GameObject PlaymodeManager;

		public Vector3 currentCheckpoint;

		public bool debugMode;
		public float gameTime;

		public CharacterManager playerCharacter;

		private void OnEnable()
		{
			CheckpointZone.checkpointChangeEvent += ChangeCheckpoint;

			InputControls inputControls = new InputControls();

			inputControls.Enable();
		}

		private void OnDisable()
		{
			CheckpointZone.checkpointChangeEvent -= ChangeCheckpoint;
		}

		void Awake()
		{
			
		}

		public void ChangeCheckpoint(Vector3 newCheckpointPosition)
		{
			this.currentCheckpoint = newCheckpointPosition;

			// SAVE GAME
		}

		// Start is called before the first frame update
		void Start()
		{
			gameTimer = new SimpleTimer();

			this.stateManager.ChangeState(new GamePrepareState(stateManager));
		}

		// Update is called once per frame
		void Update()
		{
			this.stateManager.ExecuteStateUpdate();
			gameTime = gameTimer.elapsed;
		}

		public void SpawnPlayer()
		{
			playerCharacter = Instantiate(playerCharacterPrefab, currentCheckpoint, new Quaternion(currentCheckpoint.x, currentCheckpoint.y, currentCheckpoint.z, 0)).GetComponent<CharacterManager>();
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
