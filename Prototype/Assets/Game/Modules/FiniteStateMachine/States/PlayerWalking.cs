using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace snd
{
    public class PlayerWalking : IState
    {
	    private Rigidbody rigidBody;
		private Transform transform;
		private float moveSpeed;
		private float horizontalInput;
		private float verticalInput;
		private float angle;
        private Vector3 moveVelocity;

        private System.Action<ReturnMovementVector> playerWalkingCallback;

	    public PlayerWalking(Rigidbody rigidBody, Transform transform, float moveSpeed, float horizontalInput, float verticalInput, System.Action<ReturnMovementVector> playerWalkingCallback)
        {
            this.rigidBody = rigidBody;
			this.transform = transform;
			this.moveSpeed = moveSpeed;
			this.horizontalInput = horizontalInput;
			this.verticalInput = verticalInput;
			this.playerWalkingCallback = playerWalkingCallback;
		}

        public void Enter()
        {
            
        }

        public void Execute()
        {
            float horizontalLook = InputManager.Instance.xboxRHorizontal;
            float verticalLook = -InputManager.Instance.xboxRVertical;

            if (horizontalLook != 0f || verticalLook != 0f) {
                angle = Mathf.Atan2(horizontalLook, verticalLook) * Mathf.Rad2Deg;

                this.transform.rotation = Quaternion.Euler( 0f, angle, 0f);
            }
            
            this.rigidBody.velocity = moveVelocity;

            var playerWalking = new ReturnMovementVector(horizontalInput, verticalInput);

			this.playerWalkingCallback(playerWalking);
        }

        public void Exit(){}
    }

    public class ReturnMovementVector
    {
        public ReturnMovementVector(float horizontalInput, float verticalInput)
        {
            Debug.Log(horizontalInput + "/" + verticalInput);
        }
    }
}