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
        
        bool isFizz = fizzInt % 3 == 0;
        bool isBuzz = buzzInt % 5 == 0;

        for (int j = 1; j < 100; j++)
        {
            if (isFizz && isBuzz)
            {
                Debug.Log(j);
                Debug.Log(fizz + buzz);
            }
            else if (isFizz)
            {
                Debug.Log(j);
                Debug.Log(fizz);
            }
            else if (isBuzz)
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
