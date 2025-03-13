using UnityEngine;

namespace State
{

    public class MoveState : StateBase
    {
        public MoveState(PlayerController controller) : base(controller)
        {
        }

        public override void Enter()
        {
            Debug.Log("Move State: Entering");

        }

        public override void Update()
        {
            if (!playerController.IsMoving())
            {
                playerController.ChangeState(new IdleState(playerController));
            }
            else if (playerController.IsJumping())
            {
                playerController.ChangeState(new JumpState(playerController));
            }
        }

        public override void Exit()
        {
            //  Debug.Log("Move State: Exiting");
        }
    }

}