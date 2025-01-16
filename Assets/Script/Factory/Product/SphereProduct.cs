using UnityEngine;
using Random = UnityEngine.Random;

namespace FactoryPattern
{
    public class SphereProduct : ShapeBase
    {
        private MeshRenderer _renderer;
        private void Awake()
        {
            _renderer = GetComponent<MeshRenderer>();
        }

        public override void InitializeShape(int index)
        {
            _renderer.material.color = Random.ColorHSV();
            var startPosition = new Vector3(Random.Range(-1f,1f),3.5f,Random.Range(-1f,1f));
            transform.localPosition = startPosition;
        }
    }
}