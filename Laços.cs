using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laços : MonoBehaviour
{
    int x = 11;
    string[] inimigos;
        void Start()
    {
        print("Laços Foreach"); //Percorre lista de variaveis
        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "mark";

        foreach (string nome in inimigos) //percorrendo todos os nomes do inimigos
        {
            print(nome);
        }


        print("Laços Do While"); //tem pelo menos a primeira interação
        do
        {
            print(x);
            print("Olá mundo!");
            x++;

        } while (x<=10 ); //condição


        print("Laços While");
        while (x<=10) //uma condição
        {
            print(x);
            x++; //precisa incrementar
        }
        //Laços FOR
        print("Laços For");
        for (int x = 0; x <= 10; x++) //define variavel, condição e incrementa
        {
            print(x);
            print("Olá Mundo!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
