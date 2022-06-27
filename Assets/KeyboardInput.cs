using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    void Update()
    {
        // -1 ~ 1の値
        float x = Input.GetAxis("Horizontal");
        Debug.Log("x: " + x);
        float y = Input.GetAxis("Vertical");
        Debug.Log("y: " + y);
        
        // -1, 0, 1の値
        float rawX = Input.GetAxisRaw("Horizontal");
        Debug.Log("rawX: " + rawX);
        float rawY = Input.GetAxisRaw("Vertical");
        Debug.Log("rawY: " + rawY);

        // keydown
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key down");
        }
    }
}
