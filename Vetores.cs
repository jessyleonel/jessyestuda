using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vetores : MonoBehaviour
{
    // Vetor 1D e Matriz 2D
    void Start()
    {
        int[] array = { 1, 2, 3, 4 };
        print(array[0]); //resultado 1, começa do 0

        int[] arraay = new int[4] { 4, 3, 2, 1 };
        print(arraay[0]);

        int[] arrayy = new int[4];
        arrayy[0] = 1;
        arrayy[1] = 2;
        arrayy[2] = 3;
        arrayy[3] = 4;
        print(arrayy[2]);

        //array com laços

        int[] arrla = new int[10];
        for(int i = 0; i<10; i++)
        {
            arrla[i] = i + 1;
            print(i + ":" + arrla[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
