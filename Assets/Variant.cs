using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variant : MonoBehaviour
{
    void Start()
    {
        string stringVariant = "string variant";
        int intVariant = 10;
        float floatVariant = 5.3f;
        bool falseVariant = intVariant == floatVariant;
        bool trueVariant = intVariant != floatVariant;
        
        Debug.Log(stringVariant);
        Debug.Log(intVariant);
        Debug.Log(floatVariant);
        Debug.Log(falseVariant);
        Debug.Log(trueVariant);
    }

    void Update()
    {
        
    }
}
