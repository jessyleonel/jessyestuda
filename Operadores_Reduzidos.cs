using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores_Reduzidos : MonoBehaviour
{
    //Variaveis
    int carteira, bolsa, banco, emprestimo;

    void Start()
    {
        //declara��o de variaveis
        carteira = 10;
        bolsa = 13;
        
               
        //equa��es reduzidas
        carteira += 2; //redu��o da equa��o carteira = carteira + 2;
        bolsa -= 2;
        banco = bolsa + carteira;   emprestimo = banco - bolsa;
        banco *= 2;   
        emprestimo /= 2;

        //exibi��o de resultado
     
            print("Carteira " + carteira);
            print("Bolsa " + bolsa);
            print("Banco " + banco);
            print("Emprestimo " + emprestimo);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
