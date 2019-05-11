using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
	public class GameManager : Game.Base.SingletonPersistent<GameManager>
	{
        public SimpleTimer timer;

        public float gameSpeed;
		public float gameTime;

        private StateMachine stateManager = new StateMachine();

		// Start is called before the first frame update
		void Start()
		{
            timer = new SimpleTimer();
		}

		// Update is called once per frame
		void Update()
		{
            gameSpeed = Time.timeScale;
			gameTime = timer.elapsed;
		}
	}
}
