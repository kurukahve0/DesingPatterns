using DG.Tweening;
using UnityEngine;

namespace Command
{
    public class SphereMovementController : MonoBehaviour
    {
        public GameObject LinePrefab;
        
        public void MoveWithDirection(Vector3 direction)
        {
            transform.DOMove(transform.position + direction, .5f)
                .SetEase(Ease.OutBack);
        }
        
        
    }
}