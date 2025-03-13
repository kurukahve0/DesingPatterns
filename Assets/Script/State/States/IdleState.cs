using UnityEngine;

namespace State
{

    public class IdleState : StateBase
    {
        public IdleState(PlayerController controller) : base(controller)
        {
        }

        public override void Enter()
        {
            Debug.Log("Idle State: Entering");

        }

        public override void Update()
        {
            if (playerController.IsMoving())
            {
                playerController.ChangeState(new MoveState(playerController));
            }
            else if (playerController.IsJumping())
            {
                playerController.ChangeState(new JumpState(playerController));
            }
        }

        public override void Exit()
        {
            //   Debug.Log("Idle State: Exiting");
        }
    }

}