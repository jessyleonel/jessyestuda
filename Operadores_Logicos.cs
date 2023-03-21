using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores_Logicos : MonoBehaviour
{
    /* 
     Oeradores Relacionais
    == igual -> compara se s�o iguais 
    != diferente 
    > maior que            < menor que
    >= maior ou igual �    <= menor ou igual �

     Operadores L�gicos
    AND -> E &&    OR -> OU ||    NOT -> N�O (!)

    */

    //Declara��o de Vari�veis
    int num1 = 10;
    int num2 = 20;

    void Start()
    {
        //exibi��o de resultados
        //AND -> E
        print("Operadores L�gicos AND &&");
        print(num1 != num2 && num1 != num2); //true
        print(num1 != num2 && num1 == num2); //false
        print(num1 == num2 && num1 != num2); //false
        print(num1 == num2 && num1 == num2); //false

        //OR -> ou s� � falso se tudo for falso
        print("Operadores L�gicos OR ||");
        print(num1 != num2 || num1 != num2); //true
        print(num1 != num2 || num1 == num2); //true
        print(num1 == num2 || num1 != num2); //true
        print(num1 == num2 || num1 == num2); //false

        //NOT -> N�O Ele inverte a verdade
        print("Operadores L�gicos NOT !");
        print(!(num1 != num2)); //false
        print(!(num1 == num2)); //true

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
