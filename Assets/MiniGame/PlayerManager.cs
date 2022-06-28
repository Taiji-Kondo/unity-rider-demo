using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, 0, y) * 0.1f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Game Over");
        // Restart the game
        SceneManager.LoadScene("SampleScene");
    }
}
