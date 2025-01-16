using UnityEngine;

namespace FactoryPattern
{
    public class SphereFactory : Factory
    {
        [SerializeField] private SphereProduct sphereProduct;
        
        public override ShapeBase GetShape(Transform parent,int index)
        {
            var shape = Instantiate(sphereProduct, parent);
            shape.InitializeShape(index);
            return shape ;
        }
    }
}