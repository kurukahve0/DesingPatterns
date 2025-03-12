using DG.Tweening;
using UnityEngine;

namespace Command
{
    public class MoveCommand : ICommand
    {
        private readonly SphereMovementController _sphereMovementController;
        private readonly Vector3 _direction;
        private GameObject _activeLine;
        
        public MoveCommand(SphereMovementController sphereMovementController, Vector3 direction)
        {
            _sphereMovementController= sphereMovementController;
            _direction = direction;
        }


        public void Execute()
        { 
            _sphereMovementController.MoveWithDirection(_direction);
            Vector3 linePos=_sphereMovementController.transform.position;
            linePos.y=0.5f;
            linePos+=_direction/2f;
            float angle = Mathf.Atan2(_direction.z, _direction.x) * Mathf.Rad2Deg;
            _activeLine=
                Object.Instantiate(_sphereMovementController.LinePrefab,linePos,Quaternion.Euler(0,angle,0),null);
        }

        public void Undo()
        {
            _sphereMovementController.MoveWithDirection(-_direction);
            Object.Destroy(_activeLine);
        }
    }
    
}