using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeration : MonoBehaviour
{
    private enum OBJECT_TYPE
    {
        CUBE,
        SPHERE,
        CAPSULE,
        CYLINDER,
    }

    [SerializeField] private OBJECT_TYPE objectType;
    
    void Start()
    {
        objectType = OBJECT_TYPE.SPHERE;
        
        Debug.Log(objectType);
        // Enumeration number
        Debug.Log((int)objectType);
    }

    void Update()
    {
        
    }
}
