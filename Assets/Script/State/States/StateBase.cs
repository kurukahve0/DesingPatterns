using UnityEngine;

namespace State
{

    public abstract class StateBase
    {
        protected PlayerController playerController;

        protected StateBase(PlayerController controller)
        {
            this.playerController = controller;
        }


        public virtual void Enter()
        {
        }


        public virtual void Update()
        {
        }


        public virtual void Exit()
        {
        }
    }

}