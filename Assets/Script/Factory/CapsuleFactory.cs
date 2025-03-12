using UnityEngine;

namespace FactoryPattern
{
    public class CapsuleFactory : Factory
    {
        [SerializeField] private CapsuleProduct capsuleProduct;
        
        
        public override ShapeBase GetShape(Transform parent,int index)
        {
            var shape = Instantiate(capsuleProduct, parent);
            shape.InitializeShape(index);
            return shape;
        }
    }
}