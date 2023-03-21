using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operacao_Aritmetica : MonoBehaviour
{
    //Variaveis

    int num1, num2, num3, resultado, result2, result3, result4, result5;
    int result6, result7, result8;
    

    void Start()
    {
        //variavel
        num1 = 10;
        num2 = 20;
        num3 = 2;

        //operações
        resultado = num1 + num2;
        result2 = num1 - num2;
        result3 = num2 * num3;
        result4 = num1 / num3; 
        result5 = num1 % num3; //% modulo mostra o resto de uma divisão
        result6 = num1 + num2 * num3;
        result7 = (num1 + num2) * num3;
        result8 = num3 * ((num1 + num2) / 4);

        //resultados
        print(resultado);  print(result2); print(result3); print(result4);
        print(result5);    print(result6); print(result7); print(result8);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
