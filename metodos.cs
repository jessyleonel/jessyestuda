using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    Metodoos somar;

    void Start()
    {
        int val;
        int val2;

        somar = new Metodoos();
        val = somar.soma(10,2);
        val2 = somar.soma(5, 2);

        print(val);
        print(val2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Metodoos : MonoBehaviour
{

    public int soma(int valor1, int valor2) // voidenão precisa retornar
    {
        int resultado = valor1 + valor2;

        return resultado;

    }
}
