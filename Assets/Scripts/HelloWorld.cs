using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int A, B, C;
    int numberX, Y;
    float X;
    bool Z;

    // Start is called before the first frame update
    void Start()
    {
     A = 3;
     B = 4;
     C = A + 2 * B;
     C = C + B;
     B = C - A;
     A = B * C;
        Debug.Log(A + B + C);

        X = 2.0f;
        X = Mathf.Pow((X + X), 2);
        X = Mathf.Sqrt(X + Mathf.Sqrt(X) + 5);
        Debug.Log(X);

        numberX = 5;
        Y = numberX - 2;
        numberX = Y * Y + 1;
        Z = (numberX > (Y + 5));
        

        A = 10;
        B = 5;
        A = B;
        B = A;
        Debug.Log(A + B);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
