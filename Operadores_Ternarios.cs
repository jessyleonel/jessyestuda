using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores_Ternarios : MonoBehaviour
{
    //Declara��o de Variaveis
    int moedasHerois = 20;
    int vidaHero = 100;
    string result;
    
    void Start()
    {
        print("IF e ELSE");
        if(moedasHerois >= vidaHero)
        {
            print("Posso comprar a vida.");
        }

        else
        {
            print("N�o tenho dinheiro.");
        }
        

        //Condi��o True:False resumir o if e o else
        print("Resumo de if e else True:False");
        result = (moedasHerois >= vidaHero) ? "Posso comprar vida." : "N�o tenho dinheiro";
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
