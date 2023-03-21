using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores_Logicos : MonoBehaviour
{
    /* 
     Oeradores Relacionais
    == igual -> compara se são iguais 
    != diferente 
    > maior que            < menor que
    >= maior ou igual à    <= menor ou igual à

     Operadores Lógicos
    AND -> E &&    OR -> OU ||    NOT -> NÃO (!)

    */

    //Declaração de Variáveis
    int num1 = 10;
    int num2 = 20;

    void Start()
    {
        //exibição de resultados
        //AND -> E
        print("Operadores Lógicos AND &&");
        print(num1 != num2 && num1 != num2); //true
        print(num1 != num2 && num1 == num2); //false
        print(num1 == num2 && num1 != num2); //false
        print(num1 == num2 && num1 == num2); //false

        //OR -> ou só é falso se tudo for falso
        print("Operadores Lógicos OR ||");
        print(num1 != num2 || num1 != num2); //true
        print(num1 != num2 || num1 == num2); //true
        print(num1 == num2 || num1 != num2); //true
        print(num1 == num2 || num1 == num2); //false

        //NOT -> NÃO Ele inverte a verdade
        print("Operadores Lógicos NOT !");
        print(!(num1 != num2)); //false
        print(!(num1 == num2)); //true

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
