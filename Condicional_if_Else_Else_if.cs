using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional_if_Else_Else_if : MonoBehaviour
{
    //Decla��o de Variaveis
    int moedasHero = 100;
    int vidaHero = 100;


    void Start()
    {
        if(moedasHero == vidaHero) //primeira condi��o exigida
        {
            print("Posso comprar Vida e fico sem moedas.");
        }

        else if(moedasHero > vidaHero) //Segunda condi��o possivel
        {
            print("Posso comprar Vida e sobra moedas.");
        }

        else //caso as condi��es n�o sejam cumpridas
        {
            print("N�o posso comprar Vida.");        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
