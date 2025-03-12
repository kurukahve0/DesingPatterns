using UnityEngine;

namespace Command
{
    public class ButtonsController : MonoBehaviour
    {
        [SerializeField] private SphereMovementController _sphereMovementController;
        
        
        public void MoveForward()
        {
            ICommand moveForwardCommand = new MoveCommand(_sphereMovementController, Vector3.forward);
            CommandInvoker.InvokeCommand(moveForwardCommand);
        }
        
        public void MoveBackward()
        {
            ICommand moveBackwardCommand = new MoveCommand(_sphereMovementController, Vector3.back);
            CommandInvoker.InvokeCommand(moveBackwardCommand);
        }
        
        public void MoveLeft()
        {
            ICommand moveLeftCommand = new MoveCommand(_sphereMovementController, Vector3.left);
            CommandInvoker.InvokeCommand(moveLeftCommand);
        }
        
        public void MoveRight()
        {
            ICommand moveRightCommand = new MoveCommand(_sphereMovementController, Vector3.right);
            CommandInvoker.InvokeCommand(moveRightCommand);
        }
        
        
        public void Undo()
        {
            CommandInvoker.UndoCommand();
        }
        
        public void Redo()
        {
            CommandInvoker.RedoCommand();
        }
    }
}