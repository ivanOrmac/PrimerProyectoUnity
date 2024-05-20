using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    private int grams;

    // Start is called before the first frame update
    void Start()
    {
        grams = 1200;

        GetPounds();
        GetOunce();
        GetKilograms();
    }

    private void GetPounds()
    {
        float result;

        result = grams / 453.6f;
        Debug.Log(grams + " gramos en libras son " + result);
    }

    private void GetOunce()
    {
        float result;

        result = grams / 28.35f;
        Debug.Log(grams + " gramos en onzas son " + result);
    }

    private void GetKilograms()
    {
        float result;

        result = grams / 1000f;
        Debug.Log(grams + " gramos en Kg son " + result);
    }
}
