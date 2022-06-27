using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSample : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
    }
    
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TriggerStay");
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");
    }
}
