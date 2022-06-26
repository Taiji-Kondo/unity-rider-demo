using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour
{
    void Start()
    {
        string fizz = "Fizz";
        string buzz = "Buzz";

        int fizzInt = 3;
        int buzzInt = 5;

        for (int j = 1; j < 100; j++)
        {
            if (j % fizzInt == 0 && j % buzzInt == 0)
            {
                Debug.Log(j);
                Debug.Log(fizz + buzz);
            }
            else if (j % fizzInt == 0)
            {
                Debug.Log(j);
                Debug.Log(fizz);
            }
            else if (j % buzzInt == 0)
            {
                Debug.Log(j);
                Debug.Log(buzz);
            }
            else
            {
                Debug.Log(j);
            }
        }

    }

    void Update()
    {
        
    }
}
