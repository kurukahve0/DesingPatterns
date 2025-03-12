using System.Collections.Generic;
using UnityEditor;

namespace Command
{
    public class CommandInvoker
    {
        
        private static Stack<ICommand> _undoStack = new ();
        private static Stack<ICommand> _redoStack = new ();
        
        
        public static void InvokeCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public static void UndoCommand()
        {
            if(_undoStack.Count==0)
                return;
            
            ICommand command = _undoStack.Pop();
            _redoStack.Push(command);
            command.Undo();
        }
        
        public static void RedoCommand()
        {
            if(_redoStack.Count==0)
                return;
            
            ICommand command = _redoStack.Pop();
            _undoStack.Push(command);
            command.Execute();
        }
        
        
        
    }
}