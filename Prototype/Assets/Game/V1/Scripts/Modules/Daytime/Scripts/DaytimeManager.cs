using System;
using UnityEngine;

using Game.V1.FSM;
using Game.V1.State;

namespace Game.V1.Manager
{
	public class DaytimeManager : Game.V1.Base.SingletonPersistent<DaytimeManager>
	{
		private FiniteStateMachine stateManager = new FiniteStateMachine();

		public Light sun;

		public Cubemap cubeMapDawn;
		public Cubemap cubeMapDay;
		public Cubemap cubeMapDusk;
		public Cubemap cubeMapNight;

		private void Awake()
		{
			SetDay();
		}

		private void Update()
		{
			this.stateManager.ExecuteStateUpdate();
		}

		public void SetDawn()
		{
			this.stateManager.ChangeState(new DaytimeDawnState(stateManager, sun));
		}

		public void SetDay()
		{
			this.stateManager.ChangeState(new DaytimeDayState(stateManager, sun));
		}

		public void SetDusk()
		{
			this.stateManager.ChangeState(new DaytimeDuskState(stateManager, sun));
		}

		public void SetNight()
		{
			this.stateManager.ChangeState(new DaytimeNightState(stateManager, sun));
		}
	}
}