using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_Continue : MonoBehaviour
{
    int x = 11;
    string[] inimigos;

    //break -> abandonar um la�o
    //continue ->
    void Start()
    {
        //La�os For com break
        print("La�o For break 5");
        for (int x = 0; x<=10; x++)
        {
            print(x);
            if (x == 5) { break; }
        }
        //La�os Foreach com break
        print("La�os Foreach com break"); //Percorre lista de variaveis
        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "mark";

        foreach (string nome in inimigos) //percorrendo todos os nomes do inimigos
        {
            print(nome);
            if (nome == "atirador") { break; }
        }
        //La�os Foreach com continue
        print("La�os Foreach com contiue"); //Percorre lista de variaveis
        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "mark";

        foreach (string nome in inimigos) //percorrendo todos os nomes do inimigos
        {
            print(nome);
            if (nome == "matador") { continue;}
            print(nome);
        }
        //La�os For com continue
        print("La�o For continue 5");
        for (int x = 0; x <= 10; x++)
        {
            print(x);
            if (x == 5) { continue; }
            print(x);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
