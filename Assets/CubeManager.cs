using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        // ↓ Can ommiting this line
        // Transform cube = GetComponent<Transform>();
        
        rb = GetComponent<Rigidbody>();
        // rb.velocity = new Vector3(1, 0, 0);
    }

    void Update()
    {
        // transform.position += new Vector3(0.1f, 0, 0);
        // transform.Translate(new Vector3(0.1f, 0, 0));
        // transform.Rotate(new Vector3(0.1f, 0, 0));
        
        rb.AddForce(new Vector3(1, 0, 0));
    }
}
