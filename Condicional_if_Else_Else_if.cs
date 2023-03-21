using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional_if_Else_Else_if : MonoBehaviour
{
    //Declação de Variaveis
    int moedasHero = 100;
    int vidaHero = 100;


    void Start()
    {
        if(moedasHero == vidaHero) //primeira condição exigida
        {
            print("Posso comprar Vida e fico sem moedas.");
        }

        else if(moedasHero > vidaHero) //Segunda condição possivel
        {
            print("Posso comprar Vida e sobra moedas.");
        }

        else //caso as condições não sejam cumpridas
        {
            print("Não posso comprar Vida.");        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
