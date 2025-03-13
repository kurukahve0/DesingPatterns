using UnityEngine;

namespace State
{

    public class JumpState : StateBase
    {
        public JumpState(PlayerController controller) : base(controller)
        {
        }

        public override void Enter()
        {
            Debug.Log("Jump State: Entering");
            playerController.Jump();
        }

        public override void Update()
        {
            if (playerController.IsGrounded() && !playerController.IsJumping()
                                           )
            {
                if (playerController.IsMoving())
                {
                    playerController.ChangeState(new MoveState(playerController));
                }
                else
                {
                    playerController.ChangeState(new IdleState(playerController));
                }
            }
        }

        public override void Exit()
        {
            // Debug.Log("Jump State: Exiting");
        }
    }

}