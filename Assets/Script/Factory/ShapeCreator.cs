using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace FactoryPattern
{
    public class ShapeCreator : MonoBehaviour
    {
        [SerializeField] private Factory[] factories;
        [SerializeField] private TextMeshPro countText;
        
        private Queue<ShapeBase> _activeShapes=new();
        private int _createCounter;

        private void Start()
        {
            countText.text = _activeShapes.Count.ToString();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var factory = factories[_createCounter % factories.Length];
                var shape = factory.GetShape(transform,_createCounter);
                _activeShapes.Enqueue(shape);
                _createCounter++;
                countText.text = _activeShapes.Count.ToString();
                return;
            }

            if (Input.GetMouseButtonDown(1))
            {
                if(_activeShapes.Count==0)
                    return;
                Destroy(_activeShapes.Dequeue().gameObject);
                countText.text = _activeShapes.Count.ToString();
            }
            
            
        }
    }
}