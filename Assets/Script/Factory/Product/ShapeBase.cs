using Unity.VisualScripting;
using UnityEngine;

namespace FactoryPattern
{
    public abstract class ShapeBase : MonoBehaviour
    {
        public abstract void InitializeShape(int index);
        
        
    }
}