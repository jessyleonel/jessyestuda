using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeradores : MonoBehaviour
{
    //fica mais facil de trabalhar com AI e nomes
    enum AI{Atacar, Correr, Patrulhar}
    void Start()
    {
        AI vilaoFase1 = AI.Patrulhar;
        AI vilaoFase2 = AI.Atacar;
        AI vilaoFase3 = AI.Correr;

        print("O Vilão da fase 1 está a: " + vilaoFase1);
        print("O Vilão da fase 2 está a: " + vilaoFase2);
        print("O Vilão da fase 3 está a: " + vilaoFase3);

        int v1 = (int)vilaoFase3;
        print("Conferindo o indice " + v1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
