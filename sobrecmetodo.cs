using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobrecmetodo : MonoBehaviour
{
    calculadora calc;

    void Start()
    {
        int resultINT;
        float resultFLOAT;

        calc = new calculadora();
        resultINT = calc.calcula(5, 2);
        resultFLOAT = calc.calcula(2.5f,4.4f);

        print(resultINT);
        print(resultFLOAT);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class calculadora
{
    public int calcula (int x, int y)
    {
        return x + y;
    }

    public float calcula(float x, float y) //
    {
        return x + y;
    }
}