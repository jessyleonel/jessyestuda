using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour { 
 
    //  nomes das variaveis compativeis com o que faz
    int moedas; // Vari�vei de n�mero inteiro
    float dinheiro; // Vari�vel de n�mero flutuante
    bool duvida = true; // Verdadeiro ou falso
    string texto = "Ol� mundo!"; //Escritas

    /*
 
    Tudo dentro disso � coment�rio
 
    */

    // Chama uma vez
    void Start()
    {
        dinheiro = 03.2023f;
        moedas = 17;

        print(moedas);
        print(dinheiro);
        print(duvida);
        print(texto);
    }
   
    // Chama 1v por frame
    void Update()
    {
        

    }
}
