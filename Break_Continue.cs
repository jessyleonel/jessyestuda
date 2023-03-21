using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_Continue : MonoBehaviour
{
    int x = 11;
    string[] inimigos;

    //break -> abandonar um laço
    //continue ->
    void Start()
    {
        //Laços For com break
        print("Laço For break 5");
        for (int x = 0; x<=10; x++)
        {
            print(x);
            if (x == 5) { break; }
        }
        //Laços Foreach com break
        print("Laços Foreach com break"); //Percorre lista de variaveis
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
        //Laços Foreach com continue
        print("Laços Foreach com contiue"); //Percorre lista de variaveis
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
        //Laços For com continue
        print("Laço For continue 5");
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
