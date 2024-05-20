using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Temperature : MonoBehaviour
{

    private int farenheit;
    private int celsius;

    // Start is called before the first frame update
    void Start()
    {
        farenheit = 50;
        celsius = 10;

        FarenheitToCelsius();
        CelsiusToFarenheit();
        
    }

    private void FarenheitToCelsius()
    {
        float result;

        result = (farenheit - 32)/1.8f;
        Debug.Log(farenheit + " grados farenheit en celsius son " + result);
    }

    private void CelsiusToFarenheit()
    {
        float result;

        result = (1.8f) * celsius + 32;
        Debug.Log(celsius + " grados celsius en farenheit son " + result);
    }
}
