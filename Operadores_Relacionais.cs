using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores_Relacionais : MonoBehaviour
{
    /*
     == igual -> compara se são iguais 
     != diferente 
     > maior que            < menor que
     >= maior ou igual à    <= menor ou igual à
     
     */

    //Declaração de Variáveis

    int num1 = 10;
    int num2 = 20;

    void Start()
    {
        //exibre resultados
        print(num1 == num2);         print(num1 != num2);
        print(num1 > num2);          print(num1 < num2);
        print(num1 >= num2);         print(num1 <= num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
