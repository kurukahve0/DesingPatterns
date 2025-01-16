using System.Collections;
using System.Collections.Generic;
using FactoryPattern;
using UnityEngine;

#region FactoryPattern

public abstract class Factory : MonoBehaviour
{ 
    public abstract ShapeBase GetShape(Transform parent,int index);
    
}


#endregion